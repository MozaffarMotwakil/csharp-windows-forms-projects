using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlippingCardsGame
{
    public partial class frmMain : Form
    {
        struct stGameManager
        {
            public short FailedAttemptsCount;
            public List<Button> CardsButtons;
            public Button Choice_1;
            public Button Choice_2;
            public int RoundSeconds;
            public bool inGame;
        }

        stGameManager GameManager = new stGameManager();

        Random random = new Random();

        public frmMain()
        {
            InitializeComponent();
        }

        private void SetCardsButtons()
        {
            GameManager.CardsButtons = new List<Button>
            {
                button1, button2, button3, button4,
                button5, button6, button7, button8,
                button9, button10, button11, button12,
                button13, button14, button15, button16,
                button17, button18, button19, button20
            };
        }

        private void GenerateValuesToCardsButtons(List<Button> cardsButtons)
        {
            while (cardsButtons.Count != 0)
            {
                byte randomValue = (byte)random.Next(0, 100);

                cardsButtons[0].Tag = randomValue;
                cardsButtons.RemoveAt(0);

                int sameButtonIndex = random.Next(0, cardsButtons.Count);
                cardsButtons[sameButtonIndex].Tag = randomValue;
                cardsButtons.RemoveAt(sameButtonIndex);
            }
        }

        private void CheckFromMatched()
        {
            if (GameManager.Choice_1 != null && GameManager.Choice_2 != null)
            {
                lblChoice1.Text = "?";
                lblChoice2.Text = "?";

                if (GameManager.Choice_1.Tag.ToString() != GameManager.Choice_2.Tag.ToString())
                {
                    GameManager.Choice_1.Enabled = true;
                    GameManager.Choice_2.Enabled = true;

                    GameManager.Choice_1.Text = "?";
                    GameManager.Choice_2.Text = "?";

                    GameManager.Choice_1.BackColor = Color.FromArgb(128, 255, 128);
                    GameManager.Choice_2.BackColor = Color.FromArgb(128, 255, 128);

                    GameManager.FailedAttemptsCount++;
                    lblFailedAttempts.Text = GameManager.FailedAttemptsCount.ToString();
                }

                GameManager.Choice_1 = null;
                GameManager.Choice_2 = null;
            }
        }

        private void UpdateChoiceInformation(Button btn)
        {
            if (GameManager.Choice_1 == null)
            {
                GameManager.Choice_1 = btn;
                lblChoice1.Text = btn.Text;
            }
            else
            {
                GameManager.Choice_2 = btn;
                lblChoice2.Text = btn.Text;
            }
        }

        private void Flip(object sender)
        {
            Button btn = sender as Button;
            
            if (btn.Text == "?")
            {
                btn.Text = btn.Tag.ToString();
                btn.BackColor = Color.Gray;
                btn.Enabled = false;
                UpdateChoiceInformation(btn);
            }
        }

        private bool isEndGame()
        {
            SetCardsButtons();
            return GameManager.CardsButtons.All(btn => !btn.Enabled);
        }

        private void EndGame()
        {
            GameManager.inGame = false;
            increaseTimer.Stop();
            MessageBox.Show("Congratulations, you have successfully completed the round. To continue playing again, click on Generates.", "Successfully completed the round", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CardButton_Click(object sender, EventArgs e)
        {
            if (!GameManager.inGame)
                return;

            CheckFromMatched();
            Flip(sender);

            if (isEndGame())
            {
                EndGame();
            }

        }

        private void ResetScreen()
        {
            SetCardsButtons();

            GameManager.CardsButtons.ForEach(btn =>
            {
                btn.Text = "?";
                btn.BackColor = Color.FromArgb(128, 255, 128);
                btn.Enabled = true;
            });

            GameManager.FailedAttemptsCount = 0;
            lblFailedAttempts.Text = "0";

            GameManager.RoundSeconds = 0;
            lblTimeTaken.Text = "00:00:00";

            lblChoice1.Text = lblChoice2.Text = "?";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (GameManager.inGame)
            {
                MessageBox.Show("You cannot generate values ​​during gameplay", "Generate Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GameManager.inGame = true;
            increaseTimer.Start();

            ResetScreen();
            GenerateValuesToCardsButtons(GameManager.CardsButtons);
        }
        
        private void increaseTimer_Tick(object sender, EventArgs e)
        {
            lblTimeTaken.Text = TimeSpan.FromSeconds(GameManager.RoundSeconds++).ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetCardsButtons();
        }

    }
}
