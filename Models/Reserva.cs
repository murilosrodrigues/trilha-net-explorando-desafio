namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           if (hospedes.Count() >  Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A suite não tem capacidade para atender essa reserva");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Suite.Capacidade;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0.00M;
            var temDesconto = DiasReservados >= 10;

            if (temDesconto)
                valor = (DiasReservados * Suite.ValorDiaria) * (10 / 100);
            else
                valor = (DiasReservados * Suite.ValorDiaria);
            return valor;
        }
    }
}