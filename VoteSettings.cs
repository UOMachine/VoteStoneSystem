namespace Server.Vote
{
    [PropertyObject]
    public sealed class VoteSettings
    {
        public override string ToString()
        {
            return @"Vote Settings";
        }

        [CommandProperty(AccessLevel.Administrator)]
        public static bool VoteEnabled { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static bool RewardGmpEnabled { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string ShardName { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string URLVote { get; set; }
        [CommandProperty(AccessLevel.Administrator)]
        public static string MSG1 { get; set; }
        [CommandProperty(AccessLevel.Administrator)]
        public static string MSG2 { get; set; }
        [CommandProperty(AccessLevel.Administrator)]
        public static string MSG3 { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int HUE1 { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int HUE2 { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int HUE3 { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string GumpTitle { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpTitleX { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpTitleY { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpTitleHue { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRD { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRDY { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRDX { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRDW { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRDH { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRD2 { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRD2Y { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRD2X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRD2W { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GMPBckGRD2H { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTNX { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTNY { get; set; }
        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTN2X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTN2Y { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTN3X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTN3Y { get; set; }
        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTN4X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTN4Y { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTN5X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int GumpBTN5Y { get; set; }


        [CommandProperty(AccessLevel.Administrator)]
        public static string BTN1Name { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN1X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN1Y { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN1Hue { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string BTN2Name { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN2X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN2Y { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN2Hue { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string BTN3Name { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN3X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN3Y { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN3Hue { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string BTN4Name { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN4X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN4Y { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN4Hue { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string BTN5Name { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN5X { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN5Y { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static int BTN5Hue { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string ItemName1 { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string ItemName2 { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string ItemName3 { get; set; }

        [CommandProperty(AccessLevel.Administrator)]
        public static string ItemName4 { get; set; }
        public VoteSettings(bool voteEnabled, bool rwgmpEnabled,
            string shardName, string urlVote, string msg1, string msg2, string msg3, int hue1, int hue2, int hue3, string gumpTitle, int gumpTitleX, int gumpTitleY,
            int gumpTitleHue, int bckGrd, int bckGrdx, int bckGrdy, int bckGrdw, int bckGrdh, int bckGrd2, int bckGrd2x, int bckGrd2y, int bckGrd2w, int bckGrd2h,
            int bTNx, int bTNy, int bTN2x, int bTN2y, int bTN3x, int bTN3y, int bTN4x, int bTN4y, int bTN5x, int bTN5y, string btn1n, int btn1x, int btn1y, int btn1Hue,
            string btn2n, int btn2x, int btn2y, int btn2Hue, string btn3n, int btn3x, int btn3y, int btn3Hue, string btn4n, int btn4x, int btn4y, int btn4Hue,
            string btn5n, int btn5x, int btn5y, int btn5Hue, string item1, string item2, string item3, string item4)
        {
            VoteEnabled = voteEnabled;
            RewardGmpEnabled = rwgmpEnabled;
            ShardName = shardName;
            URLVote = urlVote;
            MSG1 = msg1;
            MSG2 = msg2;
            MSG3 = msg3;
            HUE1 = hue1;
            HUE2 = hue2;
            HUE3 = hue3;
            GumpTitle = gumpTitle;
            GumpTitleX = gumpTitleX;
            GumpTitleY = gumpTitleY;
            GumpTitleHue = gumpTitleHue;
            GMPBckGRD = bckGrd;
            GMPBckGRDX = bckGrdx;
            GMPBckGRDY = bckGrdy;
            GMPBckGRDW = bckGrdw;
            GMPBckGRDH = bckGrdh;
            GMPBckGRD2 = bckGrd2;
            GMPBckGRD2X = bckGrd2x;
            GMPBckGRD2Y = bckGrd2y;
            GMPBckGRD2W = bckGrd2w;
            GMPBckGRD2H = bckGrd2h;
            GumpBTNX = bTNx;
            GumpBTNY = bTNy;
            GumpBTN2X = bTN2x;
            GumpBTN2Y = bTN2y;
            GumpBTN3X = bTN3x;
            GumpBTN3Y = bTN3y;
            GumpBTN4X = bTN4x;
            GumpBTN4Y = bTN4y;
            GumpBTN5X = bTN5x;
            GumpBTN5Y = bTN5y;

            BTN1Name = btn1n;
            BTN1X    = btn1x;
            BTN1Y    = btn1y;
            BTN1Hue  = btn1Hue;

            BTN2Name = btn2n;
            BTN2X = btn2x;
            BTN2Y = btn2y;
            BTN2Hue = btn2Hue;

            BTN3Name = btn3n;
            BTN3X = btn3x;
            BTN3Y = btn3y;
            BTN3Hue = btn3Hue;

            BTN4Name = btn4n;
            BTN4X = btn4x;
            BTN4Y = btn4y;
            BTN4Hue = btn4Hue;

            BTN5Name = btn5n;
            BTN5X = btn5x;
            BTN5Y = btn5y;
            BTN5Hue = btn5Hue;

            ItemName1 = item1;
            ItemName2 = item2;
            ItemName3 = item3;
            ItemName4 = item4;
        }

        public VoteSettings(GenericReader reader)
        {
            Deserialize(reader);
        }

        public void Serialize(GenericWriter writer)
        {
            writer.Write(0);
            writer.Write(VoteEnabled);
            writer.Write(RewardGmpEnabled);
            writer.Write(ShardName);
            writer.Write(URLVote);
            writer.Write(MSG1);
            writer.Write(MSG2);
            writer.Write(MSG3);
            writer.Write(HUE1);
            writer.Write(HUE2);
            writer.Write(HUE3);
            writer.Write(GumpTitle);
            writer.Write(GumpTitleX);
            writer.Write(GumpTitleY);
            writer.Write(GumpTitleHue);
            writer.Write(GMPBckGRD);
            writer.Write(GMPBckGRDX);
            writer.Write(GMPBckGRDY);
            writer.Write(GMPBckGRDW);
            writer.Write(GMPBckGRDH);
            writer.Write(GMPBckGRD2);
            writer.Write(GMPBckGRD2X);
            writer.Write(GMPBckGRD2Y);
            writer.Write(GMPBckGRD2W);
            writer.Write(GMPBckGRD2H);
            writer.Write(GumpBTNX);
            writer.Write(GumpBTNY);
            writer.Write(GumpBTN2X);
            writer.Write(GumpBTN2Y);
            writer.Write(GumpBTN3X);
            writer.Write(GumpBTN3Y);
            writer.Write(GumpBTN4X);
            writer.Write(GumpBTN4Y);
            writer.Write(GumpBTN5X);
            writer.Write(GumpBTN5Y);

            writer.Write(BTN1Name);
            writer.Write(BTN1X);
            writer.Write(BTN1Y);
            writer.Write(BTN1Hue);

            writer.Write(BTN2Name);
            writer.Write(BTN2X);
            writer.Write(BTN2Y);
            writer.Write(BTN2Hue);

            writer.Write(BTN3Name);
            writer.Write(BTN3X);
            writer.Write(BTN3Y);
            writer.Write(BTN3Hue);

            writer.Write(BTN4Name);
            writer.Write(BTN4X);
            writer.Write(BTN4Y);
            writer.Write(BTN4Hue);

            writer.Write(BTN5Name);
            writer.Write(BTN5X);
            writer.Write(BTN5Y);
            writer.Write(BTN5Hue);
            writer.Write(ItemName1);
            writer.Write(ItemName2);
            writer.Write(ItemName3);
            writer.Write(ItemName4);
        }

        public static void Deserialize(GenericReader reader)
        {
            _ = reader.ReadInt();
            VoteEnabled = reader.ReadBool();
            RewardGmpEnabled = reader.ReadBool();
            ShardName = reader.ReadString();
            URLVote = reader.ReadString();
            MSG1 = reader.ReadString();
            MSG2 = reader.ReadString();
            MSG3 = reader.ReadString();
            HUE1 = reader.ReadInt();
            HUE2 = reader.ReadInt();
            HUE3 = reader.ReadInt();
            GumpTitle = reader.ReadString();
            GumpTitleX = reader.ReadInt();
            GumpTitleY = reader.ReadInt();
            GumpTitleHue = reader.ReadInt();
            GMPBckGRD = reader.ReadInt();
            GMPBckGRDX = reader.ReadInt();
            GMPBckGRDY = reader.ReadInt();
            GMPBckGRDW = reader.ReadInt();
            GMPBckGRDH = reader.ReadInt();
            GMPBckGRD2 = reader.ReadInt();
            GMPBckGRD2X = reader.ReadInt();
            GMPBckGRD2Y = reader.ReadInt();
            GMPBckGRD2W = reader.ReadInt();
            GMPBckGRD2H = reader.ReadInt();
            GumpBTNX = reader.ReadInt();
            GumpBTNY = reader.ReadInt();
            GumpBTN2X = reader.ReadInt();
            GumpBTN2Y = reader.ReadInt();
            GumpBTN3X = reader.ReadInt();
            GumpBTN3Y = reader.ReadInt();
            GumpBTN4X = reader.ReadInt();
            GumpBTN4Y = reader.ReadInt();
            GumpBTN5X = reader.ReadInt();
            GumpBTN5Y = reader.ReadInt();

            BTN1Name = reader.ReadString();
            BTN1X = reader.ReadInt();
            BTN1Y = reader.ReadInt();
            BTN1Hue = reader.ReadInt();

            BTN2Name = reader.ReadString();
            BTN2X = reader.ReadInt();
            BTN2Y = reader.ReadInt();
            BTN2Hue = reader.ReadInt();

            BTN3Name = reader.ReadString();
            BTN3X = reader.ReadInt();
            BTN3Y = reader.ReadInt();
            BTN3Hue = reader.ReadInt();

            BTN4Name = reader.ReadString();
            BTN4X = reader.ReadInt();
            BTN4Y = reader.ReadInt();
            BTN4Hue = reader.ReadInt();

            BTN5Name = reader.ReadString();
            BTN5X = reader.ReadInt();
            BTN5Y = reader.ReadInt();
            BTN5Hue = reader.ReadInt();

            ItemName1 = reader.ReadString();
            ItemName2 = reader.ReadString();
            ItemName3 = reader.ReadString();
            ItemName4 = reader.ReadString();

            if (MSG1 == null)
            {
                MSG1 = "You have already voted.";
            }

            if (MSG2 == null)
            {
                MSG2 = "Thank you for supporting us.";
            }

            if (MSG3 == null)
            {
                MSG3 = "Vote Stone Disabled";
            }

            if (GumpTitle == null)
            {
                GumpTitle = "My Shard";
            }

            if (BTN1Name == null)
            {
                BTN1Name = "Dagger";
            }

            if (BTN2Name == null)
            {
                BTN2Name = "Dagger";
            }

            if (BTN3Name == null)
            {
                BTN3Name = "Dagger";
            }

            if (BTN4Name == null)
            {
                BTN4Name = "Dagger";
            }

            if (BTN5Name == null)
            {
                BTN5Name = "Dagger";
            }

            if (ItemName1 == null)
            {
                ItemName1 = "Dagger";
            }

            if (ItemName2 == null)
            {
                ItemName2 = "Dagger";
            }

            if (ItemName3 == null)
            {
                ItemName3 = "Dagger";
            }

            if (ItemName4 == null)
            {
                ItemName4 = "Dagger";
            }
        }
    }
}
