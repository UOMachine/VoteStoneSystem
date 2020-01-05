using Server.Items;
using Server.Network;
using Server.Gumps;
using Server.Commands;
using System;

namespace Server.Vote
{
    public class VoteRewardGump : Gump
    {
        public static VoteSettings Settings { get; set; }
        public static string GumpTitle { get => VoteSettings.GumpTitle; set => VoteSettings.GumpTitle = value; }
        public static int GumpTitleX { get => VoteSettings.GumpTitleX; set => VoteSettings.GumpTitleX = value; }
        public static int GumpTitleY { get => VoteSettings.GumpTitleY; set => VoteSettings.GumpTitleY = value; }
        public static int GumpTitleHue { get => VoteSettings.GumpTitleHue; set => VoteSettings.GumpTitleHue = value; }
        public static int GMPBckGRD { get => VoteSettings.GMPBckGRD; set => VoteSettings.GMPBckGRD = value; }
        public static int GMPBckGRD2 { get => VoteSettings.GMPBckGRD2; set => VoteSettings.GMPBckGRD2 = value; }
        public static int GMPBckGRDX { get => VoteSettings.GMPBckGRDX; set => VoteSettings.GMPBckGRDX = value; }
        public static int GMPBckGRDY { get => VoteSettings.GMPBckGRDY; set => VoteSettings.GMPBckGRDY = value; }
        public static int GMPBckGRDW { get => VoteSettings.GMPBckGRDW; set => VoteSettings.GMPBckGRDW = value; }
        public static int GMPBckGRDH { get => VoteSettings.GMPBckGRDH; set => VoteSettings.GMPBckGRDH = value; }
        public static int GMPBckGRD2X { get => VoteSettings.GMPBckGRD2X; set => VoteSettings.GMPBckGRD2X = value; }
        public static int GMPBckGRD2Y { get => VoteSettings.GMPBckGRD2Y; set => VoteSettings.GMPBckGRD2Y = value; }
        public static int GMPBckGRD2W { get => VoteSettings.GMPBckGRD2W; set => VoteSettings.GMPBckGRD2W = value; }
        public static int GMPBckGRD2H { get => VoteSettings.GMPBckGRD2H; set => VoteSettings.GMPBckGRD2H = value; }
        public static int GumpBTNX { get => VoteSettings.GumpBTNX; set => VoteSettings.GumpBTNX = value; }
        public static int GumpBTNY { get => VoteSettings.GumpBTNY; set => VoteSettings.GumpBTNY = value; }
        public static int GumpBTN2X { get => VoteSettings.GumpBTN2X; set => VoteSettings.GumpBTN2X = value; }
        public static int GumpBTN2Y { get => VoteSettings.GumpBTN2Y; set => VoteSettings.GumpBTN2Y = value; }
        public static int GumpBTN3X { get => VoteSettings.GumpBTN3X; set => VoteSettings.GumpBTN3X = value; }
        public static int GumpBTN3Y { get => VoteSettings.GumpBTN3Y; set => VoteSettings.GumpBTN3Y = value; }
        public static int GumpBTN4X { get => VoteSettings.GumpBTN4X; set => VoteSettings.GumpBTN4X = value; }
        public static int GumpBTN4Y { get => VoteSettings.GumpBTN4Y; set => VoteSettings.GumpBTN4Y = value; }
        public static int GumpBTN5X { get => VoteSettings.GumpBTN5X; set => VoteSettings.GumpBTN5X = value; }
        public static int GumpBTN5Y { get => VoteSettings.GumpBTN5Y; set => VoteSettings.GumpBTN5Y = value; }
        public static string BTN1Name { get => VoteSettings.BTN1Name; set => VoteSettings.BTN1Name = value; }
        public static int BTN1X { get => VoteSettings.BTN1X; set => VoteSettings.BTN1X = value; }
        public static int BTN1Y { get => VoteSettings.BTN1Y; set => VoteSettings.BTN1Y = value; }
        public static int BTN1Hue { get => VoteSettings.BTN1Hue; set => VoteSettings.BTN1Hue = value; }
        public static string BTN2Name { get => VoteSettings.BTN2Name; set => VoteSettings.BTN2Name = value; }
        public static int BTN2X { get => VoteSettings.BTN2X; set => VoteSettings.BTN2X = value; }
        public static int BTN2Y { get => VoteSettings.BTN2Y; set => VoteSettings.BTN2Y = value; }
        public static int BTN2Hue { get => VoteSettings.BTN2Hue; set => VoteSettings.BTN2Hue = value; }
        public static string BTN3Name { get => VoteSettings.BTN3Name; set => VoteSettings.BTN3Name = value; }
        public static int BTN3X { get => VoteSettings.BTN3X; set => VoteSettings.BTN3X = value; }
        public static int BTN3Y { get => VoteSettings.BTN3Y; set => VoteSettings.BTN3Y = value; }
        public static int BTN3Hue { get => VoteSettings.BTN3Hue; set => VoteSettings.BTN3Hue = value; }
        public static string BTN4Name { get => VoteSettings.BTN4Name; set => VoteSettings.BTN4Name = value; }
        public static int BTN4X { get => VoteSettings.BTN4X; set => VoteSettings.BTN4X = value; }
        public static int BTN4Y { get => VoteSettings.BTN4Y; set => VoteSettings.BTN4Y = value; }
        public static int BTN4Hue { get => VoteSettings.BTN4Hue; set => VoteSettings.BTN4Hue = value; }
        public static string BTN5Name { get => VoteSettings.BTN5Name; set => VoteSettings.BTN5Name = value; }
        public static int BTN5X { get => VoteSettings.BTN5X; set => VoteSettings.BTN5X = value; }
        public static int BTN5Y { get => VoteSettings.BTN5Y; set => VoteSettings.BTN5Y = value; }
        public static int BTN5Hue { get => VoteSettings.BTN5Hue; set => VoteSettings.BTN5Hue = value; }
        public static string ItemName1 { get => VoteSettings.ItemName1; set => VoteSettings.ItemName1 = value; }
        public static string ItemName2 { get => VoteSettings.ItemName2; set => VoteSettings.ItemName2 = value; }
        public static string ItemName3 { get => VoteSettings.ItemName3; set => VoteSettings.ItemName3 = value; }
        public static string ItemName4 { get => VoteSettings.ItemName4; set => VoteSettings.ItemName4 = value; }

        //private Mobile m_Mobile;
        //private Item m_Deed;

        public VoteRewardGump(Mobile from)
          : base(0, 0)
        {
            if (from == null)
            {
                return;
            }
            //m_Mobile = from;
            Closable = true;
            Disposable = true;
            if(from.IsStaff())
            {
                Dragable = true;
            }
            else
            {
                Dragable = false;
            }
            Resizable = false;
            AddPage(0);

            AddBackground(GMPBckGRDX, GMPBckGRDY, GMPBckGRDW, GMPBckGRDH, GMPBckGRD);
            AddBackground(GMPBckGRD2X, GMPBckGRD2Y, GMPBckGRD2W, GMPBckGRD2H, GMPBckGRD2);
            AddLabel(GumpTitleX, GumpTitleY, GumpTitleHue, GumpTitle);
            AddButton(GumpBTNX, GumpBTNY, 4023, 4024, 1, GumpButtonType.Reply, 0);
            AddButton(GumpBTN2X, GumpBTN2Y, 4023, 4024, 2, GumpButtonType.Reply, 1);
            AddButton(GumpBTN3X, GumpBTN3Y, 4023, 4024, 3, GumpButtonType.Reply, 2);
            AddButton(GumpBTN4X, GumpBTN4Y, 4023, 4024, 4, GumpButtonType.Reply, 3);
            AddButton(GumpBTN5X, GumpBTN5Y, 4005, 4007, 0, GumpButtonType.Reply, 0);
            AddLabel(BTN1X, BTN1Y, BTN1Hue, BTN1Name);
            AddLabel(BTN2X, BTN2Y, BTN2Hue, BTN2Name);
            AddLabel(BTN3X, BTN3Y, BTN3Hue, BTN3Name);
            AddLabel(BTN4X, BTN4Y, BTN4Hue, BTN4Name);
            AddLabel(BTN5X, BTN5Y, BTN5Hue, BTN5Name);
            new VoteGumpTimer(from).Start();
        }

        private class VoteGumpTimer : Timer
        {
            private readonly Mobile from;

            public VoteGumpTimer(Mobile owner)
                : base(TimeSpan.FromSeconds(0.5))
            {
                from = owner;
                Priority = TimerPriority.EveryTick;
            }

            protected override void OnTick()
            {
                if (from.HasGump(typeof(VoteRewardGump)))
                {
                    from.CloseGump(typeof(VoteRewardGump));
                    from.SendGump(new VoteRewardGump(from));
                }
            }
        }

        public override void OnResponse(NetState state, RelayInfo info)
        {
            Mobile from = state.Mobile;

            switch (info.ButtonID)
            {
                case 0: //Close Gump 
                    {
                        new VoteGumpTimer(from).Stop();
                        from.CloseGump(typeof(VoteRewardGump));
                        break;
                    }
                case 1:
                    {
                        Type type = ItemSpawnerType.GetType(ItemName1);
                        Item item;
                        if (type == null)
                        {
                            from.SendAsciiMessage("Invalid Item Type");
                            new VoteGumpTimer(from).Stop();
                            from.CloseGump(typeof(VoteRewardGump));
                            break;
                        }
                        else
                        {
                            item = Activator.CreateInstance(type) as Item;
                            from.AddToBackpack(item);
                            new VoteGumpTimer(from).Stop();
                            from.CloseGump(typeof(VoteRewardGump));
                            break;
                        }
                    }
                case 2:
                    {
                        Type type = ItemSpawnerType.GetType(ItemName2);
                        Item item;
                        if (type == null)
                        {
                            from.SendAsciiMessage("Invalid Item Type");
                            new VoteGumpTimer(from).Stop();
                            from.CloseGump(typeof(VoteRewardGump));
                            break;
                        }
                        else
                        {
                            item = Activator.CreateInstance(type) as Item;
                            from.AddToBackpack(item);
                            new VoteGumpTimer(from).Stop();
                            from.CloseGump(typeof(VoteRewardGump));
                            break;
                        }
                    }
                case 3:
                    {
                        Type type = ItemSpawnerType.GetType(ItemName3);
                        Item item;
                        if (type == null)
                        {
                            from.SendAsciiMessage("Invalid Item Type");
                            new VoteGumpTimer(from).Stop();
                            from.CloseGump(typeof(VoteRewardGump));
                            break;
                        }
                        else
                        {
                            item = Activator.CreateInstance(type) as Item;
                            from.AddToBackpack(item);
                            new VoteGumpTimer(from).Stop();
                            from.CloseGump(typeof(VoteRewardGump));
                            break;
                        }
                    }
                case 4:
                    {
                        Type type = ItemSpawnerType.GetType(ItemName4);
                        Item item;
                        if (type == null)
                        {
                            from.SendAsciiMessage("Invalid Item Type");
                            new VoteGumpTimer(from).Stop();
                            from.CloseGump(typeof(VoteRewardGump));
                            break;
                        }
                        else
                        {
                            item = Activator.CreateInstance(type) as Item;
                            from.AddToBackpack(item);
                            new VoteGumpTimer(from).Stop();
                            from.CloseGump(typeof(VoteRewardGump));
                            break;
                        }
                    }

            }
        }
    }
}


