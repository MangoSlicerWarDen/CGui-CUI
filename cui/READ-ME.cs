///<summary>
///   #####                 #####       #     #      ###     
///  #     #               #     #      #     #       #      
///  #                     #            #     #       #      
///  #                     #  ####      #     #       #      
///  #            ###      #     #      #     #       #      
///  #     #      ###      #     #      #     #       #      - Picked up by - Soom#2785 
///   #####       ###       #####        #####       ###      - Original Creator - silent#1234
///                                                             - CGUI(CUI) Version - 1.0
///                                                         
/// The purpose of CUI (now known as CGUI) is to provide a console framework for easier use on console apps. 
/// Will be updated reguraly but this is a side project.
/// 
/// Language C.GUI is written in: 
///         C#
/// Languages that are supported officially:
///         C#, CONSOLE
///     
/// 
/// Documentary - 
/// 
/// C.GUI, there's no limit to what you can make with this (aside from the current controls). 
/// You could make this an updater for a .net, or possibly a c++ project (or any other language) 
/// Even though C.GUI has it's menu made in another way, it still falls under c#. That means you could easily do anything or even expand the framework yourself
/// with enough knowledge. 
/// 
/// 
/// 
/// I'll be adding some examples before the actual learning and explanation comes in.
/// 
/// 
/// Check full controls - example - 
/// Pastebin link: https://pastebin.com/raw/mgHnNhtT
/// 
/// 
/// 
/// 
/// 
/// 
/// Controls: (not finished)
/// 
/// Controls.Add(new Label("Test label"));
/// ^ Adds a label with the requested string.
/// 
/// Controls.Add(new Checkbox("Test checkbox", true));
/// ^ Adds a checkbox with the requested string, can be checked if true/false.
/// 
/// Controls.Add(new Slider("Test slider", 0, 1, 0, 100));
/// ^ Adds a slider with the requested string, can be checked for value.
/// 
/// Controls.Add(new TextBox("Test textbox", "Some text"));
/// ^ Adds a textbox with the name and content, can be changed within the app itself. Can be checked for it's contents(value)
/// 
/// Controls.Add(new TextBox("Test password field", "password", true));
/// ^ Adds a textbox with a protected char, "********". Can be changed within the app itself. Can be checked for it's contents(value)
/// 
/// Controls.Add(new ComboBox("Test combobox", new List<string>
///     {
///         "Item1",
///         "Item2",
///         "Item3",
///         "Item4",
///         "Item5"
///     }));
///     
/// ^ Adds a listbox/ComboBox with the name, and list of strings. Can be chosen within the app itself. Can be checked for the chosen value.
/// 
/// Controls.Add(new Submenu());  -> class Submenu : MenuBase
/// ^ Adds a Sub-Menu that can be edited with a class.
/// 
/// 
/// 
/// </summary>