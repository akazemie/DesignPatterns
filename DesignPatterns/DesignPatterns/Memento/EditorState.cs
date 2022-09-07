namespace DesignPatterns.Memento
{
    public class EditorState
    {
        private String content;
        private String fontName;
        private int fontSize;

        public EditorState(String content, String fontName, int fontSize)
        {
            this.content = content;
            this.fontName = fontName;
            this.fontSize = fontSize;
        }

        public String getContent()
        {
            return content;
        }

        public String getFontName()
        {
            return fontName;
        }

        public int getFontSize()
        {
            return fontSize;
        }
    }
}
