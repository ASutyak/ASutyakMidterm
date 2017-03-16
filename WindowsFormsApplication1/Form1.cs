using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int foldNum = 0;
        int numClicks = 0;
        int userTotal = 100;
        int compTotal = 100;
        int potSize = 0;
        int currentSpot = 0;
        int flushOnTable = 0;
        int straightOnTable = 0;
        int fullHouseOnTable = 0;
        int suitValue;
        Random rand;
        Image[] cardPics;
        int[] cardSuit;
        int[] cardNum;
        int[] userCards;
        int[] compCards;
        int[] tableCards;
        public Form1()
        {
            rand = new Random();
            cardSuit = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0};
            cardNum = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            userCards = new int[2] { 0, 0 };
            compCards = new int[2] { 0, 0 };
            tableCards = new int[5] { 0, 0, 0, 0, 0 };

            cardPics = new Image[53];
            cardPics[0] = Properties.Resources.AC;
            cardPics[1] = Properties.Resources.AD;
            cardPics[2] = Properties.Resources.AH;
            cardPics[3] = Properties.Resources.AS;
            cardPics[4] = Properties.Resources.X2C;
            cardPics[5] = Properties.Resources.X2D;
            cardPics[6] = Properties.Resources.X2H;
            cardPics[7] = Properties.Resources.X2S;
            cardPics[8] = Properties.Resources.X3C;
            cardPics[9] = Properties.Resources.X3D;
            cardPics[10] = Properties.Resources.X3H;
            cardPics[11] = Properties.Resources.X3S;
            cardPics[12] = Properties.Resources.X4C;
            cardPics[13] = Properties.Resources.X4D;
            cardPics[14] = Properties.Resources.X4H;
            cardPics[15] = Properties.Resources.X4S;
            cardPics[16] = Properties.Resources.X5C;
            cardPics[17] = Properties.Resources.X5D;
            cardPics[18] = Properties.Resources.X5H;
            cardPics[19] = Properties.Resources.X5S;
            cardPics[20] = Properties.Resources.X6C;
            cardPics[21] = Properties.Resources.X6D;
            cardPics[22] = Properties.Resources.X6H;
            cardPics[23] = Properties.Resources.X6S;
            cardPics[24] = Properties.Resources.X7C;
            cardPics[25] = Properties.Resources.X7D;
            cardPics[26] = Properties.Resources.X7H;
            cardPics[27] = Properties.Resources.X7S;
            cardPics[28] = Properties.Resources.X8C;
            cardPics[29] = Properties.Resources.X8D;
            cardPics[30] = Properties.Resources.X8H;
            cardPics[31] = Properties.Resources.X8S;
            cardPics[32] = Properties.Resources.X9C;
            cardPics[33] = Properties.Resources.X9D;
            cardPics[34] = Properties.Resources.X9H;
            cardPics[35] = Properties.Resources.X9S;
            cardPics[36] = Properties.Resources.X10C;
            cardPics[37] = Properties.Resources.X10D;
            cardPics[38] = Properties.Resources.X10H;
            cardPics[39] = Properties.Resources.X10S;
            cardPics[40] = Properties.Resources.JC;
            cardPics[41] = Properties.Resources.JD;
            cardPics[42] = Properties.Resources.JH;
            cardPics[43] = Properties.Resources.JS;
            cardPics[44] = Properties.Resources.QC;
            cardPics[45] = Properties.Resources.QD;
            cardPics[46] = Properties.Resources.QH;
            cardPics[47] = Properties.Resources.QS;
            cardPics[48] = Properties.Resources.KC;
            cardPics[49] = Properties.Resources.KD;
            cardPics[50] = Properties.Resources.KH;
            cardPics[51] = Properties.Resources.KS;
            cardPics[52] = Properties.Resources.cardBack;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentSpot = 0;
            foldNum = 0;
            numClicks++;
            displayBox.Text = " ";
            if (numClicks != 1)
            {
                displayBox.Text = "Error, please finish hand.";

            }
            else
            {
                userTotal = userTotal - 5;
                compTotal = compTotal - 5;
                potSize = 10;
                userMoney.Text = "$ " + userTotal.ToString();
                compMoney.Text = "$ " + compTotal.ToString();
                for (int i = 0; i < 5; i++)
                {
                    tableCards[i] = rand.Next(0, 52);
                    cardValue(tableCards[i]);

                }
                for (int j = 0; j < 2; j++)
                {
                    userCards[j] = rand.Next(0, 52);
                    cardValue(userCards[j]);
                }
                for (int k = 0; k < 2; k++)
                {
                    compCards[k] = rand.Next(0, 52);
                    cardValue(compCards[k]);
                }

                table1.Image = cardPics[tableCards[0]];
                table2.Image = cardPics[tableCards[1]];
                table3.Image = cardPics[tableCards[2]];
                table4.Image = cardPics[tableCards[3]];
                table5.Image = cardPics[tableCards[4]];
                userCard1.Image = cardPics[userCards[0]];
                userCard2.Image = cardPics[userCards[1]];

                if (doesCompFold() == true)
                {
                    displayBox.Text = "Computer Folds, you win: " + potSize.ToString();
                    numClicks = 0;
                    userTotal = userTotal + potSize;
                    userMoney.Text = "$ " + userTotal.ToString();
                }
                else
                {
                    displayBox.Text = "Computer bets, bet or fold.";
                    compTotal = compTotal - 5;
                    compMoney.Text = "$ " + compTotal.ToString();
                }
            }
        }
        public void cardValue(int cardValue)
        {
            switch(cardValue)
            {
                case 0:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 0;
                    break;
                case 1:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 0;
                    break;
                case 2:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 0;
                    break;
                case 3:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 0;
                    break;
                case 4:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 1;
                    break;
                case 5:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 1;
                    break;
                case 6:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 1;
                    break;
                case 7:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 1;
                    break;
                case 8:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 2;
                    break;
                case 9:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 2;
                    break;
                case 10:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 2;
                    break;
                case 11:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 2;
                    break;
                case 12:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 3;
                    break;
                case 13:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 3;
                    break;
                case 14:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 3;
                    break;
                case 15:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 3;
                    break;
                case 16:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 4;
                    break;
                case 17:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 4;
                    break;
                case 18:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 4;
                    break;
                case 19:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 4;
                    break;
                case 20:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 5;
                    break;
                case 21:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 5;
                    break;
                case 22:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 5;
                    break;
                case 23:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 5;
                    break;
                case 24:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 6;
                    break;
                case 25:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 6;
                    break;
                case 26:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 6;
                    break;
                case 27:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 6;
                    break;
                case 28:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 7;
                    break;
                case 29:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 7;
                    break;
                case 30:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 7;
                    break;
                case 31:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 7;
                    break;
                case 32:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 8;
                    break;
                case 33:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 8;
                    break;
                case 34:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 8;
                    break;
                case 35:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 8;
                    break;
                case 36:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 9;
                    break;
                case 37:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 9;
                    break;
                case 38:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 9;
                    break;
                case 39:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 9;
                    break;
                case 40:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 10;
                    break;
                case 41:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 10;
                    break;
                case 42:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 10;
                    break;
                case 43:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 10;
                    break;
                case 44:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 11;
                    break;
                case 45:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 11;
                    break;
                case 46:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 11;
                    break;
                case 47:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 11;
                    break;
                case 48:
                    cardSuit[currentSpot] = 1; cardNum[currentSpot] = 12;
                    break;
                case 49:
                    cardSuit[currentSpot] = 2; cardNum[currentSpot] = 12;
                    break;
                case 50:
                    cardSuit[currentSpot] = 3; cardNum[currentSpot] = 12;
                    break;
                case 51:
                    cardSuit[currentSpot] = 4; cardNum[currentSpot] = 12;
                    break;
                default:
                    break;
            }
            currentSpot++;
        }

        private void userFold_Click(object sender, EventArgs e)
        {
            foldNum++;
            if (foldNum != 1)
            {
                displayBox.Text = "Error, start a new hand.";
            }
            else
            {
                displayBox.Text = "Computer wins! Pot Size: " + potSize.ToString();
                numClicks = 0;
                compTotal = compTotal + potSize;
                compMoney.Text = "$ " + compTotal.ToString();
            }

        }
        private void userBet_Click(object sender, EventArgs e)
        {
            if (userTotal <= 0 || compTotal <= 0)
            {
                displayBox.Text = "Game Over, please restart.";

            }
            if (foldNum >= 1)
            {
                displayBox.Text = "Error, start a new hand.";
            }
            else
            {
                userTotal = userTotal - 5;
                potSize = potSize + 5;
                userMoney.Text = "$ " + userTotal.ToString();
            }
        }

        public bool pairs()
        {
           for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (cardNum[i] == cardNum[j])
                    {
                        return true;
                    }
                }
            }

           return false;
        }
        public bool twoPair()
        {
            int numPair = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    if (cardNum[i] == cardNum[j])
                    {
                        numPair++;
                    }
                }
            }
            if (numPair >= 2)
                return true;
            else
                return false;
        }
        public bool threeOfAKind()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    for (int k = 2; k < 9; k++)
                    {
                        if (cardNum[i] == cardNum[j] && cardNum[i] == cardNum[k])
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public bool fourOfAKind()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    for (int k = 2; k < 9; k++)
                    {
                        for (int l = 3; l < 9; l++)
                        {
                            if (cardNum[i] == cardNum[j] && cardNum[i] == cardNum[k] && cardNum[i] == cardNum[l])
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        public bool fullHouse()
        {
            if (threeOfAKind() == true && pairs() == true)
            {
                return true;
            }
            return false;
        }
        public bool userStraight()
        {
            int numConsecutives = 0;
            int[] userArray;
            userArray = new int[7];
            for (int fill = 0; fill < 7; fill++)
            {
                userArray[fill] = cardNum[fill];
            }
            Array.Sort(userArray);
            for (int i = 1; i < 7; i++)
            {
                if (userArray[i] == (userArray[i - 1] + 1))
                {
                    numConsecutives++;
                    if (numConsecutives >= 5)
                    {
                        return true;
                    }
                }
                else
                {
                    numConsecutives = 0;
                }
            }
            return false;
        }
        public bool compStraight()
        {
            int numConsecutives = 0;
            int[] compArray;
            compArray = new int[7];
            for (int fill = 0; fill < 5; fill++)
            {
                compArray[fill] = cardNum[fill];
            }
            compArray[5] = cardNum[7];
            compArray[6] = cardNum[8];
            Array.Sort(compArray);
            for (int i = 1; i < 7; i++)
            {
                if (compArray[i] == (compArray[i - 1] + 1))
                {
                    numConsecutives++;
                    if (i < 5)
                    {
                        straightOnTable++;
                    }
                    if (numConsecutives >= 5)
                    {
                        return true;
                    }
                }
                else
                {
                    numConsecutives = 0;
                }
            }
            return false;
        }
        public bool userFlush()
        {
            int numSame = 0;
            int[] userArray;
            userArray = new int[7];
            for (int fill = 0; fill < 7; fill++)
            {
                userArray[fill] = cardSuit[fill];
            }
            for (int i = 0; i < 7; i++)
            {
                numSame = 0;
                for (int j = 1; j < 7; j++)
                {
                    if (userArray[i] == userArray[j])
                    {
                        numSame++;
                    }
                    if (numSame >= 5)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool compFlush()
        {
            flushOnTable = 0;
            int numSame = 0;
            int[] compArray;
            compArray = new int[7];
            for (int fill = 0; fill < 5; fill++)
            {
                compArray[fill] = cardSuit[fill];
            }
            compArray[5] = cardSuit[7];
            compArray[6] = cardSuit[8];
            for (int i = 0; i < 7; i++)
            {
                numSame = 0;
                for (int j = 1; j < 7; j++)
                {
                    if (compArray[i] == compArray[j])
                    {

                        if (i < 5)
                        {
                            flushOnTable++;
                        }
                        numSame++;
                    }
                    if (numSame >= 5)
                    {
                        suitValue = i;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool userStraightFlush()
        {
            if (userStraight() == true && userFlush() == true)
                return true;
            else
                return false;
        }
        public bool compStraightFlush()
        {
            if (compStraight() == true && compFlush() == true)
                return true;
            else
                return false;
        } 

        public bool doesCompFold()
        {
            if (compStraightFlush() == true)
                return false;
            else if (fourOfAKind() == true)
                return false;
            else if (compFlush() == true)
            {
                if (flushOnTable >= 4)
                {
                    for (int i = 7; i < 9; i++)
                    {
                        if (cardSuit[i] == suitValue)
                        {
                            if (cardNum[i] < 7)
                            {
                                return true;
                            }
                        }
                    }
                    return false;
                }
                return false;
            }
            else if (compStraight() == true)
            {
                if (straightOnTable >= 4)
                {
                    for (int i = 7; i < 9; i++)
                    {
                        if (cardNum[i] <= 6)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                    return false;
            }
            else if (fullHouse() == true)
            {
                if (fullHouseOnTable >= 4)
                {
                    for (int i = 7; i < 9; i++)
                    {
                        if (cardNum[i] <= 6)
                        {
                            return true;
                        }
                    }
                    return false;
                }
                else
                    return false;
            }
            else
                return true;
        }
    }
}
