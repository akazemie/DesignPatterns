// See https://aka.ms/new-console-template for more information

using DesignPatterns.Memento;

#region Memento
var editor = new Editor();
var history = new History();

editor.setContent("Hello");
history.push(editor.createMemento());

editor.setFontName("Font 1");
history.push(editor.createMemento());

editor.setFontSize(10);
Console.WriteLine(editor);

editor.restore(history.pop());
Console.WriteLine(editor);

editor.restore(history.pop());
Console.WriteLine(editor);
#endregion