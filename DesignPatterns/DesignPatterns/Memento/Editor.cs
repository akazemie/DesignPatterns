namespace DesignPatterns.Memento
{
    public class Editor
    {
        private string content;

        public EditorState createState()
        {
            return new EditorState(content);
        }

        public void restore(EditorState state)
        {
            content = state.getContent();
        }

        public string getContent()
        {
            return content;
        }

        public void setContent(string content)
        {
            this.content = content;
        }
    }

}
