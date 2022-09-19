namespace Exercise_6
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class method
    {
        // Creating Method
        public int Method(int[] A)
        {
            if (!A.Contains(1))
            {
                return 1;
            }
            int result = A.Max();
            foreach (var numb in A)
            {
                if (numb > 0 && numb <= result)
                {
                    if (!A.Contains(numb + 1))
                    {
                        result = (numb + 1);
                    }
                }
            }
            return result;
        }
    }
}
