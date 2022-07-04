namespace thegame.Models
{
    public class UserInputDto
    {
        public UserInputDto(char keyPressed, VectorDto clickedPos)
        {
            KeyPressed = keyPressed;
            ClickedPos = clickedPos;
        }

        public char KeyPressed { get; set; }
        public VectorDto ClickedPos { get; set; }
    }
}