using System.Collections.Generic;
using Server.Gumps;
using Server.Commands;
using Server.Mobiles;
using System.IO;

namespace Server.Vote
{
    public class VoteStone : Item
    {
        private static List<Mobile> MVote;
        public static VoteSettings Settings { get; set; }
        public static bool VoteEnabled { get => VoteSettings.VoteEnabled; set => VoteSettings.VoteEnabled = value; }
        public static bool RewardGmpEnabled { get => VoteSettings.RewardGmpEnabled; set => VoteSettings.RewardGmpEnabled = value; }
        public static string ShardName { get => VoteSettings.ShardName; set => VoteSettings.ShardName = value; }
        public static string URLVote { get => VoteSettings.URLVote; set => VoteSettings.URLVote = value; }
        public static string MSG1 { get => VoteSettings.MSG1; set => VoteSettings.MSG1 = value; }
        public static string MSG2 { get => VoteSettings.MSG2; set => VoteSettings.MSG2 = value; }
        public static string MSG3 { get => VoteSettings.MSG3; set => VoteSettings.MSG3 = value; }
        public static int HUE1 { get => VoteSettings.HUE1; set => VoteSettings.HUE1 = value; }
        public static int HUE2 { get => VoteSettings.HUE2; set => VoteSettings.HUE2 = value; }
        public static int HUE3 { get => VoteSettings.HUE3; set => VoteSettings.HUE3 = value; }

        public static void Initialize()
        {
            EventSink.WorldSave += new WorldSaveEventHandler(SaveVoteSettings);
            if (File.Exists(Path.Combine(Core.BaseDirectory, @"Saves\VoteSettings.bin")))
            {
                Load();
            }
            else
            {
                LoadDefaults();
            }

            CommandSystem.Register("SetVoteStone", AccessLevel.Administrator, new CommandEventHandler(SetVoteStone_OnCommand));
        }

        public static void SaveVoteSettings(WorldSaveEventArgs e)
        {
            string SavePath = Path.Combine(Core.BaseDirectory, @"Saves\VoteSettings.bin");

            if (!Directory.Exists(Path.Combine(Core.BaseDirectory, @"Saves")))
            {
                Directory.CreateDirectory(Path.Combine(Core.BaseDirectory, @"Saves"));
            }

            GenericWriter writer = new BinaryFileWriter(SavePath, true);

            try
            {
                writer.Write(0);
                Settings.Serialize(writer);
            }
            catch
            { }
            writer.Close();
        }

        private static void Load()
        {
            try
            {
                string SavePath = Path.Combine(Core.BaseDirectory, @"Saves\VoteSettings.bin");

                using (FileStream fs = new FileStream(SavePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    BinaryReader br = new BinaryReader(fs);
                    BinaryFileReader reader = new BinaryFileReader(br);

                    int version = reader.ReadInt();

                    switch (version)
                    {
                        case 0:
                            {
                                Settings = new VoteSettings(reader);
                                break;
                            }
                    }
                }
            }
            catch
            {
            }
        }
        private static void LoadDefaults()
        {
            string vote1 = "You have already voted.";
            string vote2 = "Thank you for supporting us.";
            string vote3 = "Vote Stone Disabled";
            string gtitle = "Pick Your Reward";
            Settings = new VoteSettings(true, true, "My shard", "http://uoportal.com/", vote1, vote2, vote3, 10, 15, 20, gtitle, 40, 12, 37, 3000,
                0, 0, 300, 400, 9270, 8, 8, 284, 384, 74, 111, 74, 140, 74, 169, 74, 198, 12, 360, "Close", 52, 360, 37, "Vote Dagger", 113, 111, 0, "Vote Dagger", 113, 140, 0,
                "Vote Dagger", 113, 169, 0, "Vote Dagger", 113, 198, 0, "Dagger", "Dagger", "Dagger", "Dagger");
        }

        [Usage("SetVoteStone")]
        [Description("Enables use of setting the vote stone settings.")]
        public static void SetVoteStone_OnCommand(CommandEventArgs e)
        {
            PlayerMobile from = e.Mobile as PlayerMobile;

            if (from != null && !from.Deleted)
            {
                from.SendGump(new PropertiesGump(e.Mobile, Settings));
            }
        }

        [Constructable]
        public VoteStone() : base(0xED4)
        {
            Movable = false;
            Hue = 1165;
            Name = "Vote Stone";

            MVote = new List<Mobile>();
        }

        public override void AddNameProperties(ObjectPropertyList list)
        {
            base.AddNameProperties(list);
            list.Add(1070722, "Click to Vote for us on {0}", ShardName);
        }

        public VoteStone(Serial serial) : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write(0);
            writer.WriteMobileList(MVote, true);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            _ = reader.ReadInt();
            MVote = reader.ReadStrongMobileList();
        }

        public override void OnDoubleClick(Mobile from)
        {
            PlayerMobile pm = from as PlayerMobile;
            if (VoteEnabled)
            {
                if (MVote.Contains(from))
                {
                    from.SendMessage(HUE1, "{0}", MSG1);
                    return;
                }

                if (from != null && from.Alive)
                {
                    MVote.Add(from);
                    if (RewardGmpEnabled)
                    {
                        from.SendGump(new VoteRewardGump(from));
                    }
                    from.LaunchBrowser(URLVote);

                    from.SendMessage(HUE2, "{0}", MSG2);
                }
            }
            else
                from.SendMessage(HUE3, "{0}", MSG3);
        }
    }
}
