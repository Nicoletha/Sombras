using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StatuBar_NAGD.Vista
{
    public class VMmainpage
    {
        public VMmainpage()
        {

        }
        public void Ocultar()
        {
            DependencyService.Get<VMstatubar>().OcultarStatusBar();
        }
        public void Mostrar()
        {
            DependencyService.Get<VMstatubar>().MostrarStatusBar();
        }
        public void Traslucido()
        {
            DependencyService.Get<VMstatubar>().Traslucido();
        }
        public void Transparente()
        {
            DependencyService.Get<VMstatubar>().Transparente();
        }
        public void CambiarColor()
        {
            DependencyService.Get<VMstatubar>().CambiarColor();
        }

        public ICommand OcultarCommand => new Command(Ocultar);
        public ICommand MostrarCommand => new Command(Mostrar);
        public ICommand TraslucidoCommand => new Command(Traslucido);
        public ICommand TransparenteCommand => new Command(Transparente);
        public ICommand CambiarColorCommand => new Command(CambiarColor);
    }
}