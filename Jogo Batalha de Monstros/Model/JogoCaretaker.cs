using System.Collections.Generic;

namespace BatalhaDeMonstros
{
    public class JogoCaretaker
    {
        private Stack<JogoMemento> historico;

        public JogoCaretaker()
        {
            historico = new Stack<JogoMemento>();
        }

        public void SalvarEstado(JogoMemento memento)
        {
            historico.Push(memento);
        }

        public JogoMemento CarregarEstado()
        {
            return historico.Count > 0 ? historico.Pop() : null;
        }
    }
}
