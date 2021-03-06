using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleep
{
    class Module
    {
        private int index = 0;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        private int sum = 0;
        public int Sum
        {
            get
            {
                return sum;
            }
            set
            {
                sum = value;
            }
        }

        private string[] question = { "Насколько вы довольны своим сном?",
            "В котором часу вы заснули?", "Вы просыпались по среди ночи?",
            "В котором часу вы проснулись?", "Вам снились кошмары?",
            "Вам было легко встать?", "Как вы себя чувтсовали после пробуждения?", "Опищите тип сна одним словом"};

        public string Question
        {
            get
            {
                return question[index];
            }
        }

        private string[] answer_1 = { "Полностью доволен(а)",
            "До 12 часов ночи", "Нет, спал(а) как младенец",
            "Между 6-8 часами утра", "Нет",
            "Да, как только открыл(а) глаза сразу встал(а)", "Хорошо, бодро", "Позитивный"};
        public string Answer_1
        {
            get
            {
                return answer_1[index];
            }
        }

        private string[] answer_2 = { "Достаточно доволен(а)",
            "После 12 часов ночи", "Да, буквально 1 раз",
            "После 8 часов утра", "Были волнительные моменты",
            "Нет, ещё некоторое время провёл(а) на кровати", "Хорошо, сонно", "Грустный"};
        public string Answer_2
        {
            get
            {
                return answer_2[index];
            }
        }

        private string[] answer_3 = { "Недовольен(а)",
            "Между 2-4 часами ночи", "Да, несколько раз",
            "После 10 часов утра", "Да",
            "Нет, мне было очень сложно встать", "Плохо, сонно", "Негативный"};
        public string Answer_3
        {
            get
            {
                return answer_3[index];
            }
        }
    }
}
