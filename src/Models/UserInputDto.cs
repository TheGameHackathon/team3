namespace thegame.Models
{
    public class UserInputDto
    {
        public UserInputDto(int keyPressed, VectorDto clickedPos)
        {
            KeyPressed = keyPressed;
            ClickedPos = clickedPos;
        }

        public int KeyPressed { get; set; }
        public VectorDto ClickedPos { get; set; }
    }
}