using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_11
{
    static class DateTimeHelper
    {
        // метод расширение TakeDays(n) для DateTime
        // которое возвращает IEnumerable<DateTime> содержащее
        // n следующих за текущем днем дней.
        public static IEnumerable<DateTime> TakeDays(this DateTime d, int n)
        {

            for (int i = 0; i < n; i++)
            {
                DateTime tmp = d.AddDays(i + 1);

                yield return tmp; // yield - итератор представляет метод, 
                                  //в котором используется ключевое слово yield
                                  //для перебора по коллекции или массиву
            }

        }
    }
}
