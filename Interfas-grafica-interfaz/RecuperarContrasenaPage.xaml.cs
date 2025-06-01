using Microsoft.Maui.Controls;
using System;

namespace AgendaPersonal
{
    public partial class RecuperarContrasenaPage : ContentPage
    {
        private string? _generatedCode;
        private string? _userEmail;


        public RecuperarContrasenaPage()
        {
            InitializeComponent();
        }

        private async void OnSendCodeClicked(object sender, EventArgs e)
        {
            try
            {
                _userEmail = EmailEntry.Text;

                if (string.IsNullOrWhiteSpace(_userEmail) || !_userEmail.Contains("@"))
                {
                    await DisplayAlert("Error", "Ingresa un correo v�lido", "OK");
                    return;
                }

                _generatedCode = new Random().Next(100000, 999999).ToString();
                await DisplayAlert("C�digo de prueba", _generatedCode, "OK");
                CodeFrame.IsVisible = true;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error cr�tico", ex.Message, "OK");
            }
        }

        private async void OnConfirmClicked(object sender, EventArgs e)
        {
            if (CodeEntry.Text != _generatedCode)
            {
                await DisplayAlert("Error", "C�digo inv�lido", "OK");
                return;
            }

            if (NewPasswordEntry.Text?.Length < 6)
            {
                await DisplayAlert("Error", "La contrase�a debe tener al menos 6 caracteres", "OK");
                return;
            }

           
            Preferences.Set($"password_{_userEmail}", NewPasswordEntry.Text);

            await DisplayAlert("�xito", "Contrase�a actualizada correctamente", "OK");
            await Shell.Current.GoToAsync("..");
        }
    }
}