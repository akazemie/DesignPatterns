namespace DesignPatterns.Memento
{
    public class Editor
    {
        private String content;
        private String fontName;
        private int fontSize;

        public EditorState createMemento()
        {
            return new EditorState(content, fontName, fontSize);
        }

        public void restore(EditorState memento)
        {
            this.content = memento.getContent();
            this.fontName = memento.getFontName();
            this.fontSize = memento.getFontSize();
        }

        public String getContent()
        {
            return content;
        }

        public void setContent(String content)
        {
            this.content = content;
        }

        public String getFontName()
        {
            return fontName;
        }

        public void setFontName(String fontName)
        {
            this.fontName = fontName;
        }

        public int getFontSize()
        {
            return fontSize;
        }

        public void setFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        } 
        public override String ToString()
        {
            return "Document{" +
                    "content='" + content + '\'' +
                    ", fontName='" + fontName + '\'' +
                    ", fontSize=" + fontSize +
                    '}';
        }
    }

}
