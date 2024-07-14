using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface IEmail
{
    void EnviarEmail();
    void CancelarEnvioDeEmail();
    void VerEmail();
    void EliminarEmail();
    void ModificarEmail();
    void EscribirEmail();
    void AgregarArchivo();
    void AgregandoLink();
    void AsignarPropietario();
}


namespace interfaces.ejemplo4
{
    public abstract class EmailModelo
    {
        public abstract void EnviarEmail();
        public abstract void CancelarEnvioDeEmail();
        public abstract void VerEmail();
        public abstract void EliminarEmail();
        public abstract void ModificarEmail();
        public abstract void EscribirEmail();
        public abstract void AgregarArchivo();
        public abstract void AgregandoLink();
        public abstract void AsignarPropietario();
    }

    public class Email : IEmail
    {
        public void AgregandoLink()
        {
            throw new NotImplementedException();
        }

        public void AgregarArchivo()
        {
            throw new NotImplementedException();
        }

        public void AsignarPropietario()
        {
            throw new NotImplementedException();
        }

        public void CancelarEnvioDeEmail()
        {
            throw new NotImplementedException();
        }

        public void EliminarEmail()
        {
            throw new NotImplementedException();
        }

        public void EnviarEmail()
        {
            throw new NotImplementedException();
        }

        public void EscribirEmail()
        {
            throw new NotImplementedException();
        }

        public void ModificarEmail()
        {
            throw new NotImplementedException();
        }

        public void VerEmail()
        {
            throw new NotImplementedException();
        }
    }
}
