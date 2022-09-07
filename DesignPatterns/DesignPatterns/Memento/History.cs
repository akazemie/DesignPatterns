namespace DesignPatterns.Memento
{
    public class History
    {
        private Stack<EditorState> mementos = new();

        public void push(EditorState memento)
        {
            mementos.Push(memento);
        }

        public EditorState pop()
        {
            return mementos.Pop();
        }
    }
}
