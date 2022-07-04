namespace thegame.Models
{
    public class UserInputDto
    {
        public UserInputDto(char keyPressed, VectorDto clickedPos)
        {
            KeyPressed = keyPressed;
            ClickedPos = clickedPos;
        }

        public byte KeyPressed { get; set; }
        public VectorDto ClickedPos { get; set; }
    }
}