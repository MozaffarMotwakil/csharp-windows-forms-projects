using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private Random random = new Random();

        enum enCharacterStatus { Capital, Small, SpecialCharacter, Number };

        struct GeneratorOptions
        {
            public byte DigitsCount;
            public bool UseLetters;
            public bool UseCapitalLetters;
            public bool UseNumbers;
            public bool UseSpecialCharacters;
            public bool UseMix;
        }

        private GeneratorOptions GetOptionsFromUI()
        {
            return new GeneratorOptions
            {
                DigitsCount = (byte)nudDigitsCount.Value,
                UseLetters = rbLetters.Checked,
                UseCapitalLetters = capitalLetterToolStripMenuItem.Checked,
                UseNumbers = rbNumbers.Checked,
                UseSpecialCharacters = rbSpecialCharacter.Checked,
                UseMix = rbMix.Checked
            };
        }

        private char RandomCharacter(enCharacterStatus status)
        {
            switch (status)
            {
                case enCharacterStatus.Capital:
                    return (char)random.Next(65, 91);
                case enCharacterStatus.Small:
                    return (char)random.Next(97, 123);
                case enCharacterStatus.SpecialCharacter:
                    return (char)random.Next(33, 48);
                default: // Number
                    return (char)random.Next(48, 58);
            }
        }

        private char GenerateCharacter(GeneratorOptions options)
        {
            if (options.UseLetters)
            {
                return options.UseCapitalLetters ? 
                    RandomCharacter(enCharacterStatus.Capital) :
                    RandomCharacter(enCharacterStatus.Small);
            }
            else if (options.UseNumbers)
            {
                return RandomCharacter(enCharacterStatus.Number);
            }
            else if (options.UseSpecialCharacters)
            {
                return RandomCharacter(enCharacterStatus.SpecialCharacter);
            }
            else
            {
                enCharacterStatus mix = (enCharacterStatus)random.Next(0, 4);
                return RandomCharacter(mix);
            }
        }

        private string GenerateResult(GeneratorOptions options)
        {
            StringBuilder result = new StringBuilder();
            byte digitsCount = (byte)nudDigitsCount.Value;

            for (byte i = 1; i <= digitsCount; i++)
            {
                result.Append(GenerateCharacter(options));
            }

            return result.ToString();
        }

        private void ResetOptions()
        {
            nudDigitsCount.Value = nudDigitsCount.Minimum;
            rbLetters.Checked = true;
            txtResult.Text = "";
        }

        private void capitalLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smallLetterToolStripMenuItem.Checked = false;
            capitalLetterToolStripMenuItem.Checked = true;
        }

        private void smallLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capitalLetterToolStripMenuItem.Checked = false;
            smallLetterToolStripMenuItem.Checked = true;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GeneratorOptions options = GetOptionsFromUI();
            txtResult.Text = GenerateResult(options);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetOptions();
        }

    }
}