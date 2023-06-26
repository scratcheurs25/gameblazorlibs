namespace mincraft.gameblazorlibs
{
    public class OBJ
    {
        public static string text_carateur(string text)
        {
            if (text == null)
            {
                return "";
            }
            else
            {
                if (text == "er")
                {
                    return "é";
                }else if(text == "et")
                {
                    return "è";
                }
                else if(text == "a")
                    {
                    return "oi";
                }else if(text == "o")
                {
                    return "au";
                }else
                {
                    return "";
                }
            }
        }
        public static string decarateur(string text)
        {
            if (decarateur == null)
            {
                return "";
            }else if(text == "é")
            {
                return "er";
            }else if (text == "è")
            {
                return "et";
            }else if (text == "oi")
            {
                return "a";
            }else if(text == "au")
            {
                return "o";
            }
            else
            {
                return "";
            }
        }
    }
}
