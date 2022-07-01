interface IButton {

}

interface IFrame{ 
    void AddButton(IButton);
}

interface UICreator{
    IFrame CreateFrame();
    IButton CreateButton();
}

class WindowsButton implements IButton {

}

class MacButton implements IButton {

}



class WindowsFrame implements IFrame{
    void AddButton(IButton) {
    }
} 

class MacFrame implements IFrame{
    void AddButton(IButton){
    }
} 



class MacUICreator implements IUICreator{
    IFrame CreateFrame(){
        return new MacFrame();
    }

    IButton CreateButton(){
        return new MacButton();
}
}

class WindowsUICreator implements IUICreator {

    IFrame CreateFrame(){
        return new WindowsFrame();
    }

    IButton CreateButton(){
        return new WindowsButton();
    }
}

class MyApp {
   
    void Initialize() {

        IUICreator c = new WindowsUICreator();
         
        WindowsFrame f = c.CreateWindowsFrame();
        WindowsButton b1 = c.CreateWindowsButton();
        WindowsButton b2 = c.CreateWindowsButton();

        f.AddButton(b1);
        f.AddButton(b2);

    }

}