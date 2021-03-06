﻿using SaveZone.Entities.CheckPasswordBindingModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveZone.Controllers
{

    public static class CheckPasswordController
    {
        public static async void CheckIfTextBoxIsEmptyAsync(string textBoxText, string textBox2Text, CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            if (textBoxText != "" && textBox2Text != "")
            {
                await Task.Run(() => SetCheckPasswordBindingModel(textBoxText, textBox2Text, CheckForm, checkPasswordBindingModel));
                await Task.Run(() => SetCheckFileBindingModelOKIsPressed(checkPasswordBindingModel));
                CheckForm.Close();
            }
            else
            {
                await Task.Run(() => ShowMessageBox());
            }
        }
        public static void CheckIfTextBoxIsEmptyNonAsync(string textBoxText, string textBox2Text, CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            if (textBoxText != "" && textBox2Text != "")
            {
                SetCheckPasswordBindingModel(textBoxText, textBox2Text, CheckForm, checkPasswordBindingModel);
                SetCheckFileBindingModelOKIsPressed(checkPasswordBindingModel);
                CheckForm.Close();
            }
            else
            {
                 ShowMessageBox();
            }
        }

        public static async void SetCancelIsPressedAsync(CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            await Task.Run(() => SetCancelIsPressed(CheckForm, checkPasswordBindingModel));
        }
        public static void SetCancelIsPressedNonAsync(CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            SetCancelIsPressed(CheckForm, checkPasswordBindingModel);
        }

        private static void SetCheckFileBindingModelOKIsPressed(CheckPasswordBindingModel checkPasswordBindingModel)
        {
            checkPasswordBindingModel.OKIsPressed = true;
        }

        private static void SetCancelIsPressed(CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            checkPasswordBindingModel.CancelIsPressed = true;
            CheckForm.Close();
        }
        private static void SetCheckPasswordBindingModel(string textBoxText, string textBox2Text, CheckPassword CheckForm, CheckPasswordBindingModel checkPasswordBindingModel)
        {
            checkPasswordBindingModel.Password = textBoxText;
            checkPasswordBindingModel.IV = textBox2Text;

        }
        private static void ShowMessageBox()
        {
            MessageBox.Show("Please enter Password and IV!", "Enter password and IV", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
