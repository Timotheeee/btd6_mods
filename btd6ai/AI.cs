using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btd6ai
{
    class AI
    {
        public static float[] getOutputTest(float[] inp)
        {
            var res = new float[4] { 0, 0, 0.35f, 0.5f };
            if (inp[2] > 0.99f)
            {
                res[1] = 1;
                res[2] = 0.6f;
            }
            if (inp[3] > 0.99f)
            {
                res[2] = 0.25f;
            }
            if (inp[5] > 0.99f)
            {
                res[0] = 1;
            }


            return res;
        } 

    }
}
