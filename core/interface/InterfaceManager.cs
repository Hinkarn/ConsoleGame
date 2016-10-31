using System.Collections.Generic;

namespace ConsoleEngine.Core.Interface
{
    public class InterfaceManager
    {
        public List<Button> buttons { get; private set; }

        public void Load()
        {
            buttons = new List<Button>();
        }

        public void Draw(Graphics.GraphicsDevice graphics)
        {
            for (int i = 0; i < buttons.Count; i++)
                buttons[i].Draw(graphics);
        }
        
        public void SelectButton(int index)
        {
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Unselect();
            }

            buttons.Find(x => x.index == index).Select();
        }
    }
}