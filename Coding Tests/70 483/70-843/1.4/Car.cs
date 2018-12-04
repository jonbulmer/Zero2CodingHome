using System;
using System.Collections.Generic;
using System.Text;

namespace Exam.Objective1_4
{
    public class Car
    {
        public event Action OnChange;

        private double speed;
        public double Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
                if (speed >= 60)
                {
                    if (OnChange != null)
                    {
                        OnChange();
                    }
                    // this is the same as above
                    OnChange?.Invoke();
                }
            }
        }

    }
}
