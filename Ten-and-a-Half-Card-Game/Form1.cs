using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末專案
{
    public partial class Form1 : Form
    {
        int[] card = new int[12];//宣告陣列card 新增12個integer
        Random rd = new Random();//宣告隨機數rd
        double playersum = 0,computersum=0;
        int computerIndex=6;//玩家牌(0~5)電腦牌(6~11)
        
        public Form1()
        {
            InitializeComponent();
            CardNumber();
        }
        private void CardNumber() //CardNumber函數 : 生成12個隨機數字
        {
            for (int i = 0; i < card.Length; i++)
            {
                card[i] = rd.Next(1, 14); // 隨機生成卡牌值範圍為1到13
            }
        }
        private void ProcessButtonClick(Button btn, int cardIndex,ref double sum,bool isPlayer)
            //ProcessButtonClick函數 : 生成的數字另外做處理
            //宣告double sum紀錄點數
            //宣告布林值分辨是否為player
        {
            int cardValue = card[cardIndex];//宣告int cardValue,cardIndex
            //cardIndex : card陣列中的索引位置(0~11)
            //cardValue : 對照索引位置出來的數值(1~13)
            string cardText = cardValue.ToString();
            //cardText : 使用者可以看到的卡牌數值
            if (cardValue == 11)
            {
                cardText = "J";
                sum += 0.5;
            }
            else if (cardValue == 12)
            {
                cardText = "Q";
                sum += 0.5;
            }
            else if (cardValue == 13)
            {
                cardText = "K";
                sum += 0.5;
            }
            else
            {
                sum += cardValue;
            }
            btn.Text = cardText; // 按鈕顯示卡牌值或字母
            if (isPlayer)
            {
                label4.Text = playersum.ToString(); // 更新累積點數顯示
            }
        }
        private void GameOver()//使用者點數過大時結束遊戲
        {
            if(playersum >= 10.5 || computersum >= 10.5)
            {
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                if(playersum > 10.5) {
                    if (card[6] == 11){   button9.Text = "J";}
                    else if(card[6]==12){   button9.Text = "Q";}
                    else if (card[6] == 13){    button9.Text = "K";}
                    else{   button9.Text = card[6].ToString();}
                    MessageBox.Show("玩家爆牌!!\n是否再來一次", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }else if (computersum > 10.5)
                {
                    if (card[6] == 11) { button9.Text = "J"; }
                    else if (card[6] == 12) { button9.Text = "Q"; }
                    else if (card[6] == 13) { button9.Text = "K"; }
                    else { button9.Text = card[6].ToString(); }
                    MessageBox.Show("電腦爆牌!!\n是否再來一次", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }else if (playersum == 10.5 && computersum == 10.5)
                {
                    if (card[6] == 11) { button9.Text = "J"; }
                    else if (card[6] == 12) { button9.Text = "Q"; }
                    else if (card[6] == 13) { button9.Text = "K"; }
                    else { button9.Text = card[6].ToString(); }
                    MessageBox.Show("平手!!\n是否再來一次", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }else if(playersum == 10.5 && computersum < 10.5)
                {
                    if (card[6] == 11) { button9.Text = "J"; }
                    else if (card[6] == 12) { button9.Text = "Q"; }
                    else if (card[6] == 13) { button9.Text = "K"; }
                    else { button9.Text = card[6].ToString(); }
                    MessageBox.Show("你贏了!!\n是否再來一次", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }else if (computersum == 10.5 && playersum < 10.5)
                {
                    if (card[6] == 11) { button9.Text = "J"; }
                    else if (card[6] == 12) { button9.Text = "Q"; }
                    else if (card[6] == 13) { button9.Text = "K"; }
                    else { button9.Text = card[6].ToString(); }
                    MessageBox.Show("挑戰失敗!!\n是否再來一次", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
        private void PlayerTurn(Button btn, int cardIndex)
        {
            ProcessButtonClick(btn, cardIndex, ref playersum, true);
            GameOver();
            if (playersum < 10.5)//玩家按button 電腦跟著按一次
            {
                ComputerTurn();
            }
        }
        private void ComputerTurn()
        {
            if (computerIndex >= card.Length) return;
            Button btn = Controls.Find("button" + (9 + (computerIndex - 6)), true).FirstOrDefault() as Button;
            if (btn != null)
            {
                ProcessButtonClick(btn, computerIndex, ref computersum, false);
                computerIndex++;
                if (btn.Name == "button9")
                {
                    button9.Text = "底牌";
                }
            }
            GameOver();
        }
        private void ResetGame()//重置遊戲
        {
            playersum = 0;
            computersum = 0;
            computerIndex = 6;
            CardNumber();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button3.Text = "底牌";
            button4.Text = "抽牌";
            button5.Text = "抽牌";
            button6.Text = "抽牌";
            button7.Text = "抽牌";
            button8.Text = "抽牌";
            button9.Text = "底牌";
            button10.Text = "抽牌";
            button11.Text = "抽牌";
            button12.Text = "抽牌";
            button13.Text = "抽牌";
            button14.Text = "抽牌";
            label4.Text = "0";
            label5.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;//sender : 偵測選取哪個button
            if (btn.Name == "button3")
            {
                PlayerTurn(button3, 0);
                button3.Enabled = false;
                GameOver();
            }
            if (btn.Name == "button4")
            {
                PlayerTurn(button4, 1);
                button4.Enabled = false;
                GameOver();
            }
            if (btn.Name == "button5")
            {
                PlayerTurn(button5, 2);
                button5.Enabled = false;
                GameOver();
            }
            if (btn.Name == "button6")
            {
                PlayerTurn(button6, 3);
                button6.Enabled = false;
                GameOver();
            }
            if (btn.Name == "button7")
            {
                PlayerTurn(button7, 4);
                 button7.Enabled = false;
                 GameOver();
            }
            if (btn.Name == "button8")
            {
                PlayerTurn(button8, 5);
                 button8.Enabled = false;
                 GameOver();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //按"停牌"則所有button皆不能點選
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            label5.Text = "已停牌";//顯示已停牌
            label5.ForeColor = Color.Red;
            ComputerTurn();
            if(playersum < 10.5 && computersum < 10.5)
            {
                if(playersum > computersum)
                {
                    if (card[6] == 11) { button9.Text = "J"; }
                    else if (card[6] == 12) { button9.Text = "Q"; }
                    else if (card[6] == 13) { button9.Text = "K"; }
                    else { button9.Text = card[6].ToString(); }
                    MessageBox.Show("你贏了!!\n是否再來一次", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }else if(playersum == computersum)
                {
                    if (card[6] == 11) { button9.Text = "J"; }
                    else if (card[6] == 12) { button9.Text = "Q"; }
                    else if (card[6] == 13) { button9.Text = "K"; }
                    else { button9.Text = card[6].ToString(); }
                    MessageBox.Show("平手!!\n是否再來一次", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    if (card[6] == 11) { button9.Text = "J"; }
                    else if (card[6] == 12) { button9.Text = "Q"; }
                    else if (card[6] == 13) { button9.Text = "K"; }
                    else { button9.Text = card[6].ToString(); }
                    MessageBox.Show("挑戰失敗!!\n是否再來一次", " ", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
