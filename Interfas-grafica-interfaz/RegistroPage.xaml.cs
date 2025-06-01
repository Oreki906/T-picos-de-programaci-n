using System;
using Microsoft.Maui.Controls;

namespace AgendaPersonal
{
    public partial class RegistroPage : ContentPage
    {
        public RegistroPage()
        {
            InitializeComponent();
        }

        private void OnRegistroClicked(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text?.Trim();
            string correo = CorreoEntry.Text?.Trim();
            string contrasena = ContrasenaEntry.Text;
            string confirmar = ConfirmarContrasenaEntry.Text;

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contrasena) ||
                string.IsNullOrWhiteSpace(confirmar))
            {
                MostrarError("Por favor, completa todos los campos.");
                return;
            }

            if (contrasena.Length < 6)
            {
                MostrarError("La contrase�a debe tener al menos 6 caracteres.");
                return;
            }

            if (contrasena != confirmar)
            {
                MostrarError("Las contrase�as no coinciden.");
                return;
            }

            // Aqu� ir�a la l�gica para guardar el usuario
            // Puedes a�adir llamada a API o guardar localmente

            DisplayAlert("Registro exitoso", "�Usuario creado correctamente!", "OK");
            // Redirigir o limpiar campos si lo deseas
        }

        private void MostrarError(string mensaje)
        {
            MensajeError.Text = mensaje;
            MensajeError.IsVisible = true;
        }
    }
}
