// See https://aka.ms/new-console-template for more information
using DesignPatterns.Memento;

Console.WriteLine("Hello, World!");


#region Memento
var editor = new Editor();
var history = new History();

editor.setContent("a");
history.push(editor.createState());

editor.setContent("b");
history.push(editor.createState());

editor.setContent("c");
editor.restore(history.pop());
editor.restore(history.pop());

Console.WriteLine(editor.getContent());
#endregion