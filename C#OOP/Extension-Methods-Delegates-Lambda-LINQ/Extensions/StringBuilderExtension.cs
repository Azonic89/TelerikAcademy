namespace Extensions
{
    using System.Text;

    public static class StringBuilderExtension
    {
        public static StringBuilder MySubString(this StringBuilder sb, int index, int lenght)
        {
            var output = new StringBuilder();

            for (int i = index; i < index + lenght; i++)
            {
                output.Append(sb[i]);
            }

            return output;
        }
    }
}
