using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class MaximizetheConfusionofanExam
    {
        public void MaxConsecutiveAnswers(string answerKey, int k)
        {
            int maxCount = 0;
            int left = 0;
            int maxFreq = 0;
            var freqMap = new Dictionary<char, int>();

            for (int right = 0; right < answerKey.Length; right++)
            {
                char currentAnswer = answerKey[right];
                freqMap[currentAnswer] = freqMap.GetValueOrDefault(currentAnswer) + 1;
                maxFreq = Math.Max(maxFreq, freqMap[currentAnswer]);

                int oppositeCount = right - left + 1 - maxFreq;

                if (oppositeCount > k)
                {
                    char leftAnswer = answerKey[left];
                    freqMap[leftAnswer]--;
                    left++;
                }

                maxCount = Math.Max(maxCount, right - left + 1);
            }

            foreach(KeyValuePair<char, int> pair in freqMap)
            {
                Console.WriteLine("key= "+pair.Key+" value= "+pair.Value);
            }

            Console.WriteLine(maxCount);
        }
    }
}
