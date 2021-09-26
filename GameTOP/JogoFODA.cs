using GameTOP.Interface;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly iJogador _JogadorA;
        private readonly iJogador _JogadorB;

        public JogoFODA(iJogador jogadorA, iJogador jogadorB)
        {
            this._JogadorA = jogadorA;
            this._JogadorB = jogadorB;    
        }

        public void IniciarJogo()
        {
            System.Console.Write(_JogadorA.Corre());
            System.Console.Write(_JogadorA.Chuta());
            System.Console.Write(_JogadorA.Passe());

            System.Console.Write("\n Próximo Jogador \n");

            System.Console.Write(_JogadorB.Corre());
            System.Console.Write(_JogadorB.Chuta());
            System.Console.Write(_JogadorB.Passe());
        }
    }

}