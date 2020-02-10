using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingTestPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 호출 log

            //solution_Re(new string[,] { { "yellow_hat", "headgear" }, { "yellow_ha", "headgear" }, { "blue_sunglasses", "eyewear" }, { "blue_sunglasse", "eyewear" }, { "blue_sunglasses", "eyewer" }, { "blue_sunglasses", "eyewer" }, { "blue_sunglasses", "eyewer" }, { "green_turban", "headgear" } });
            //foreach (int item in solution1(new int[] { 1, 5, 2, 6, 3, 7, 4 }, new int[,] { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 }, { 1, 7, 3 } }))
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in solution2(new string[] { "classic", "pop", "classic", "classic", "pop" }, new int[] { 500, 600, 150, 800, 2500 }))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine( solution3(new int[] { 99, 988 }));

            //solution4(new int[] { 3, 0, 6, 1, 5 });

            //foreach (var item in solution5(new int[] { 1,2,3,4,5, 2, 4, 4, 5,2,3, 2, 3, 4, 5, 2, 4, 4, 5, 2, 3, 2, 3, 4, 5, 2, 4, 4, 5, 2, 3, 2, 3, 4, 5, 2, 4, 4, 5, 2, 3 }))
            //{
            //    Console.WriteLine(item);
            //}

            //solution6(5, new int[] { 2,4 }, new int[] {1,3,5});
            //solution7(2, 28);
            //Console.WriteLine( solution8("abcsdfde"));
            //foreach (var item in solution9(new int[] { 2, 36, 1, 3 }, 1))
            //{
            //    Console.WriteLine( item);
            //}
            //Console.WriteLine( solution10_Re("CBD", new string[] { "BACDE", "CBADF", "ADECB", "BDA", "GFDAFC", "CBGFDAF", "BGFDAFC", "YYRECERYYGERYFBYREAFDUT", "CGFBAF" }));
            //foreach (var item in solution11(new int[] { 93, 30, 55 }, new int[] { 1, 30, 5 }))
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in solution12(new int[] { 1, 5, 3, 6, 7, 6, 5 }))
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(solution13("()(((()())(())()))(())"));

            //Console.WriteLine(solution14_SIMPLE(new int[] { 9, 8, 2, 3, 5, 6, 9, 8, 3, 4, 6, 2, 9, 3, 8, 5, 6 },15));
            #endregion
            
            Console.WriteLine(solution15(2, 10, new int[] { 7, 4, 5, 6 }));
        }

        #region 이전 작업들
        //
        // static public int solution(string[,] clothes)
        // {
        //     int answer = 0;
        //     int sum = 0;
        //
        //     Dictionary<string, int> clothesDic = new Dictionary<string, int>();
        //
        //     List<string> keys;
        //
        //     for (int i = 0; i < clothes.Length / 2; i++)
        //     {
        //         if (clothesDic.ContainsKey(clothes[i, 1]))
        //         {
        //             clothesDic[clothes[i, 1]]++;
        //         }
        //         else
        //         {
        //             clothesDic.Add(clothes[i, 1], 1);
        //         }
        //     }
        //
        //     keys = new List<string>(clothesDic.Keys);
        //     for (int i = 0; i < clothesDic.Count; i++)
        //     {
        //         sum += clothesDic[keys[i]];
        //         for (int j = i + 1; j < clothesDic.Count; j++)
        //         {
        //             sum += clothesDic[keys[i]] * clothesDic[keys[j]];
        //         }
        //     }
        //     answer = sum;
        //     return answer;
        // }
        //
        // /// <summary>
        // /// 중요 계산 로직에 결함.
        // /// </summary>
        // /// <param name="clothes"></param>
        // /// <returns></returns>
        // static public int solution_Re(string[,] clothes)
        // {
        //     int answer = 0;
        //     int sum = 1;
        //
        //     Dictionary<string, int> clothesDic = new Dictionary<string, int>();
        //
        //     for (int i = 0; i < clothes.Length / 2; i++)
        //     {
        //         if (!clothesDic.ContainsKey(clothes[i, 1])) clothesDic.Add(clothes[i, 1], 0);
        //     }
        //
        //     for (int i = 0; i < clothes.Length / 2; i++)
        //     {
        //         clothesDic[clothes[i, 1]]++;
        //     }
        //
        //     foreach (var item in clothesDic)
        //     {
        //         sum = sum * (item.Value + 1);
        //     }
        //     answer = sum - 1;
        //
        //     Console.WriteLine(answer);
        //
        //     return answer;
        // }
        //
        //
        // #region 1.K번째수
        //
        // static public int[] solution1(int[] array, int[,] commands)
        // {
        //     int[] answer = new int[commands.GetLength(0)];
        //     List<int> list = new List<int>(array);
        //     for (int i = 0; i < commands.GetLength(0); i++)
        //     {
        //         int[] temp = list.GetRange(commands[i, 0] - 1, (commands[i, 1] - commands[i, 0] + 1)).ToArray();
        //         Array.Sort(temp);
        //         answer[i] = temp[commands[i, 2] - 1];
        //     }
        //     return answer;
        // }
        // #endregion
        //
        // #region 2.베스트 앨범
        //
        //
        // public class Song
        // {
        //     public int id;
        //     public int play;
        //     public string genre;
        //
        //     public Song(int _id, int _play, string _genre)
        //     {
        //         id = _id;
        //         play = _play;
        //         genre = _genre;
        //     }
        // }
        //
        // static public int[] solution2(string[] genres, int[] plays)
        // {
        //     List<int> answer = new List<int>();
        //     List<Song> list = new List<Song>();
        //
        //     for (int i = 0; i < genres.Length; i++)
        //     {
        //         list.Add(new Song(i, plays[i], genres[i]));
        //     }
        //
        //     var querry = (
        //             from m in list
        //             group m by m.genre into song
        //             select new
        //             {
        //                 genre = song.First().genre,
        //                 playSum = song.Sum(x => x.play)
        //             }).OrderByDescending(x => x.playSum);
        //
        //     foreach (var song in querry)
        //     {
        //         var top2Song = (from m in list
        //                         where m.genre == song.genre
        //                         orderby m.play descending
        //                         select m).Take(2);
        //
        //         foreach (var item in top2Song)
        //         {
        //             answer.Add(item.id);
        //         }
        //     }
        //
        //     return answer.ToArray();
        // }
        //
        // #endregion
        //
        // #region 3.가장 큰 수
        // static public string solution3(int[] numbers)
        // {
        //     Array.Sort(numbers,
        //         (a, b) =>
        //         {
        //             return (b.ToString() + a.ToString()).CompareTo(a.ToString() + b.ToString());
        //         });
        //     string answer = "";
        //     if (numbers[0] == 0) return "0";
        //     return string.Join("", numbers);
        //
        // }
        // #endregion
        //
        // #region 4.H-Index
        // static public int solution4(int[] citations)
        // {
        //     int answer = 0;
        //
        //     Array.Sort(citations, (x, y) => { return y.CompareTo(x); });
        //
        //     for (int i = 0; i < citations.Length; i++)
        //     {
        //         if (citations[i] < i)
        //             return i;
        //     }
        //
        //     return citations.Length;
        // }
        //
        // #endregion
        //
        // #region 5.모의고사
        // /// <summary>
        // /// 1번 수포자 : [1,2,3,4,5]
        // /// 2번 수포자 : [2,1,2,3,2,4,2,5]
        // /// 3번 수포자 : [3,3,1,1,2,2,4,4,5,5]
        // /// 사실상 sort안써도 됨;
        // /// </summary>
        // /// <param name="answers"></param>
        // /// <returns></returns>
        // static public int[] solution5(int[] answers)
        // {
        //     List<int> answer = new List<int>();
        //     int[] supo1 = new int[] { 1, 2, 3, 4, 5 };
        //     int[] supo2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
        //     int[] supo3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
        //     Dictionary<int, int> supoDic = new Dictionary<int, int>();
        //     supoDic[1] = 0;
        //     supoDic[2] = 0;
        //     supoDic[3] = 0;
        //
        //     for (int i = 0; i < answers.Length; i++)
        //     {
        //         if (answers[i] == supo1[i >= supo1.Length ? i % supo1.Length : i])
        //             supoDic[1]++;
        //         if (answers[i] == supo2[i >= supo2.Length ? i % supo2.Length : i])
        //             supoDic[2]++;
        //         if (answers[i] == supo3[i >= supo3.Length ? i % supo3.Length : i])
        //             supoDic[3]++;
        //     }
        //     supoDic.OrderByDescending(x => x.Value);
        //
        //     #region 문제있던 코드
        //     //foreach (var item in supoDic)
        //     //{
        //     //    if (item.Value == supoDic.First().Value)
        //     //        answer.Add(item.Key);
        //     //}
        //     //return answer.ToArray();
        //     #endregion
        //
        //     int maxCount = Math.Max(supoDic[1], Math.Max(supoDic[2], supoDic[3]));
        //     if (maxCount == supoDic[1]) answer.Add(1);
        //     if (maxCount == supoDic[2]) answer.Add(2);
        //     if (maxCount == supoDic[3]) answer.Add(3);
        //
        //     return answer.ToArray();
        // }
        // #endregion
        //
        // #region 6.체육복
        // /// <summary>
        // /// lost와 reserve에 같은 사람이 들어있으면 return 값에 에러생김
        // /// </summary>
        // /// <param name="n"></param>
        // /// <param name="lost"></param>
        // /// <param name="reserve"></param>
        // /// <returns></returns>
        // static public int solution6(int n, int[] lost, int[] reserve)
        // {
        //     int sum = 0;
        //     int[] student = Enumerable.Repeat<int>(1, n).ToArray<int>();
        //
        //     for (int i = 0; i < lost.Length; i++)
        //     {
        //         student[lost[i] - 1]--;
        //     }
        //
        //     for (int i = 0; i < reserve.Length; i++)
        //     {
        //         student[reserve[i] - 1]++;
        //     }
        //
        //     for (int i = 0; i < student.Length; i++)
        //     {
        //         foreach (var item in student)
        //         {
        //             Console.Write(item + " ");
        //         }
        //         Console.WriteLine();
        //         switch (student[i])
        //         {
        //             case 0:
        //                 if (i + 1 != student.Length && student[i + 1] == 2)
        //                 {
        //                     student[i + 1]--;
        //                     student[i]++;
        //                     sum++;
        //                 }
        //                 break;
        //             case 2:
        //                 if (i + 1 != student.Length && student[i + 1] == 0)
        //                 {
        //                     student[i + 1]++;
        //                     student[i]--;
        //                 }
        //                 sum++;
        //                 break;
        //             default:
        //                 sum++;
        //                 break;
        //         }
        //     }
        //     Console.WriteLine(sum);
        //     return sum;
        // }
        // #endregion
        //
        // #region 7.2016년
        // static public string solution7(int a, int b)
        // {
        //     return new DateTime(2016, a, b).DayOfWeek.ToString().Substring(0, 3).ToUpper();
        // }
        //
        // #endregion
        //
        // #region 8.가운데 글자 가져오기
        //
        // static public string solution8(string s)
        // {
        //     return s.Substring((s.Length - 1) / 2, s.Length % 2 == 0 ? 2 : 1);
        // }
        // #endregion
        //
        // #region 9. 나누어 떨어지는 숫자 배열
        // static public int[] solution9(int[] arr, int divisor)
        // {
        //     List<int> answer = new List<int>();
        //     foreach (var item in arr)
        //     {
        //         Console.WriteLine(item % divisor);
        //         if (item % divisor == 0)
        //             answer.Add(item);
        //     }
        //     answer.Sort();
        //     return answer.Count == 0 ? new int[] { -1 } : answer.ToArray();
        // }
        // #endregion
        //
        // #region 10.스킬트리
        // /// <summary>
        // /// Idea : skill 배열에 있는 인덱스를 skill_trees 배열에서 검색하여 순서대로 있는지 확인.
        // /// </summary>
        // /// <param name="skill"></param>
        // /// <param name="skill_trees"></param>
        // /// <returns></returns>
        // static public int solution10(string skill, string[] skill_trees)
        // {
        //     int answer = 0;
        //     List<int> indexLIst = new List<int>();
        //     foreach (var item in skill_trees)
        //     {
        //         int[] tempArray;
        //         indexLIst.Clear();
        //         Console.WriteLine("item : " + item);
        //         for (int i = 0; i < skill.Length; i++)
        //         {
        //             Console.Write(skill[i] + " ");
        //             if (i < skill.Length - 1 && item.IndexOf(skill[i]) == -1)
        //             {
        //                 indexLIst.Clear();
        //                 break;
        //             }
        //             if (item.IndexOf(skill[i]) != -1)
        //                 indexLIst.Add(item.IndexOf(skill[i]));
        //         }
        //         Console.WriteLine();
        //         if (indexLIst.Count == 0)
        //             continue;
        //
        //         tempArray = indexLIst.ToArray();
        //         Array.Sort(tempArray);
        //         for (int i = 0; i < tempArray.Length; i++)
        //         {
        //             Console.Write(tempArray[i] + " ");
        //         }
        //         Console.WriteLine();
        //         for (int i = 0; i < tempArray.Length; i++)
        //         {
        //             Console.Write(indexLIst[i] + " ");
        //         }
        //         Console.WriteLine("\n-----");
        //
        //         if (indexLIst.ToArray().SequenceEqual(tempArray))
        //         {
        //             answer++;
        //         }
        //     }
        //     return answer;
        // }
        //
        // static public int solution10_Re(string skill, string[] skill_trees)
        // {
        //     int answer = 0;
        //     string tempStr = string.Empty;
        //     foreach (var item in skill_trees)
        //     {
        //         tempStr = string.Empty;
        //         foreach (var s in item)
        //         {
        //             if (skill.Contains(s))
        //                 tempStr += s;
        //         }
        //         Console.WriteLine("temp : " + tempStr);
        //         if (skill.Substring(0, tempStr.Length).Contains(tempStr))
        //             answer++;
        //     }
        //
        //     return answer;
        // }
        // #endregion
        //
        // #region 11. 기능개발
        //
        // static public int[] solution11(int[] progresses, int[] speeds)
        // {
        //     List<int> answer = new List<int>();
        //     int[] days = new int[progresses.Length];
        //     int max = 0, cnt = 0;
        //
        //     for (int i = 0; i < progresses.Length; i++)
        //     {
        //         days[i] = ((100 - progresses[i]) / speeds[i]) + ((100 - progresses[i]) % speeds[i] > 0 ? 1 : 0);
        //     }
        //     max = days[0];
        //     for (int i = 0; i < days.Length; i++)
        //     {
        //         if (max < days[i])
        //         {
        //             answer.Add(cnt);
        //             max = days[i];
        //             cnt = 1;
        //         }
        //         else
        //         {
        //             cnt++;
        //         }
        //
        //         if (i == days.Length - 1)
        //             answer.Add(cnt);
        //     }
        //
        //     return answer.ToArray();
        // }
        //
        //
        // #endregion
        //
        // #region 12.탑
        // /// <summary>
        // /// 신호는 무조건 왼쪽 방향으로만 발싸.
        // /// 자신보다 높은 탑만 수신 가능.
        // /// 자신보다 높은 탑이 여러개라면 가장 가까운 높은 탑이 수신.
        // /// 무식한 단순 순회 먼저?
        // /// </summary>
        // /// <param name="heights"></param>
        // /// <returns></returns>
        // static public int[] solution12(int[] heights)
        // {
        //     List<int> answer = new List<int>(heights.Length + 1);
        //
        //     for (int i = 0; i < heights.Length; i++)
        //     {
        //         for (int j = i + 1; j < heights.Length; j++)
        //         {
        //             if (heights[heights.Length - 1 - i] < heights[heights.Length - 1 - j])
        //             {
        //                 answer.Add(heights.Length - j);
        //                 break;
        //             }
        //         }
        //         if (answer.Count == i)
        //             answer.Add(0);
        //     }
        //     answer.Reverse();
        //     return answer.ToArray();
        // }
        //
        // #endregion
        //
        // #region 13.쇠막대기
        // /// <summary>
        // /// 괄호가 시작될 때마다 multi+1
        // /// 레이저 발사할 때마다 += multi
        // /// 괄호 닫힐 때마다 +=1, multi--
        // /// </summary>
        // /// <param name="arrangement"></param>
        // /// <returns></returns>
        // static public int solution13(string arrangement)
        // {
        //     int answer = 0;
        //     int order = 0;
        //
        //     for (int i = 0; i < arrangement.Length; i++)
        //     {
        //         switch (arrangement[i])
        //         {
        //             case '(':
        //                 if (arrangement[i + 1] == ')')
        //                 {
        //                     answer += order;
        //                 }
        //                 else
        //                 {
        //                     order++;
        //                 }
        //                 break;
        //             case ')':
        //                 if (arrangement[i - 1] != '(')
        //                 {
        //                     order--;
        //                     answer++;
        //                 }
        //                 break;
        //             default:
        //                 break;
        //         }
        //     }
        //     return answer;
        // }
        //
        // public int solution13_Good(string arrangement)
        // {
        //     int answer = 0;
        //     Stack<char> stk = new Stack<char>();
        //     bool isLazer = false;
        //     foreach (var c in arrangement)
        //     {
        //         if (c == '(')
        //         {
        //             stk.Push(c);
        //             isLazer = true;
        //         }
        //         else
        //         {
        //             stk.Pop();
        //             answer += isLazer ? stk.Count : 1;
        //             isLazer = false;
        //         }
        //     }
        //     return answer;
        // }
        //
        // #endregion
        //
        // #region 14. 프린터
        //
        //
        // static public int solution14(int[] priorities, int location)
        // {
        //     int answer = 0;
        //     Stack stack = new Stack();
        //     Queue queue = new Queue();
        //
        //
        //     foreach (var item in priorities)
        //     {
        //         queue.Enqueue(item);
        //     }
        //     foreach (var item in queue)
        //     {
        //         int num = (int)queue.Dequeue();
        //
        //         if (num != priorities.Max())
        //         {
        //             stack.Push(num);
        //         }
        //     }
        //
        //     return answer;
        // }
        //
        // /// <summary>
        // /// 1. 맨 앞에 있고, 내가 제일 크지 않다면, 뒤로 가면서 나보다 같거나 큰 요소 세면 됨.
        // /// 2. 중간에 있고, 내가 제일 크지 않다면, 내 앞에 큰놈만, 내 뒤는 크거나 같은놈
        // /// 3. 맨 뒤에 있고, 내가 제일 크지 않다면, 
        // /// [9,8,2,3,5,6,9,8,3,4,6,2,9,3,8,5,6]
        // /// 
        // /// 나보다 큰놈을 먼저 다 제끼고
        // /// 나보다 가장 차이나지 않게 큰놈의 뒤에 나랑 같은 수가 있는지 확인해야하는데
        // /// 
        // /// MAX 중 가장 마지막에 처리되는 INDEX를 알아야함.
        // /// 
        // /// 다 필요 없고, DIc을 QUEUE에 넣으면?
        // /// MAX값과 DEQUEU된 남은 MAX개수, MAX 갱신 등의 작업이 필요함.
        // /// </summary>
        // /// <param name="priorities"></param>
        // /// <param name="location"></param>
        // /// <returns></returns>
        // static public int solution14_SIMPLE(int[] priorities, int location)
        // {
        //     int answer = 0;
        //     Queue priorityQueue = new Queue();
        //     Queue indexQueue = new Queue();
        //     int priority = 0, index = 0;
        //     for (int i = 0; i < priorities.Length; i++)
        //     {
        //         priorityQueue.Enqueue(priorities[i]);
        //         indexQueue.Enqueue(i);
        //     }
        //
        //     while (priorityQueue.Count > 0)
        //     {
        //         priority = (int)priorityQueue.Dequeue();
        //         index = (int)indexQueue.Dequeue();
        //         if (priority == priorities.Max())
        //         {
        //             priorities[index] = -1;
        //             answer++;
        //
        //             if (index == location)
        //             {
        //                 return answer;
        //             }
        //         }
        //         else if (priority != priorities.Max())
        //         {
        //             priorityQueue.Enqueue(priority);
        //             indexQueue.Enqueue(index);
        //         }
        //     }
        //     return answer;
        // }
        //
        // public int solution14_Pair(int[] priorities, int location)
        // {
        //     int answer = 0;
        //     Queue<KeyValuePair<int, int>> que = new Queue<KeyValuePair<int, int>>();
        //     for (int i = 0; i < priorities.Length; i++)
        //     {
        //         que.Enqueue(new KeyValuePair<int, int>(i, priorities[i]));
        //     }
        //     while (true)
        //     {
        //         int nMax = que.Max(x => x.Value);
        //         var kv = que.Dequeue();
        //         if (kv.Value == nMax)
        //         {
        //             if (kv.Key == location) return answer + 1;
        //             else
        //             {
        //                 answer++;
        //                 continue;
        //             }
        //         }
        //         que.Enqueue(kv);
        //     }
        // }
        //
        // #endregion

        #endregion

        #region 15. 다리를 지나는 트럭
        /// <summary>
        /// 트럭이 막 다리에 올랐을 때, length + 1 만큼 지난 뒤에 도착함.
        /// 
        /// 1. Dequeue한 값을 nowWeight에 더했을 때 넘지 않고, 바로 앞에 자리가 있다면 Enqueue(X) - 자리는 무조건 나게됨.
        /// 
        /// 시도1 : 무식하게 index로 트럭마다 length만큼 반복하며 끝날때까지 돌기 - Queue에 올라간 요소를 접근할 방법이 없다.
        ///  > 요소마다 증가치를 두는 게 아니라 무게가 넘친다면 0을 큐에 넣는 방법으로 현재 length를 확인
        /// </summary>
        /// <param name="bridge_length"></param>
        /// <param name="weight"></param>
        /// <param name="truck_weights"></param>
        /// <returns></returns>
        static public int solution15(int bridge_length, int weight, int[] truck_weights)
        {
            int nowWeight = 0;
            int entireTime = 0;
            int truck = 0;
            int passedTruck = 0;
            // 다리를 건너는 트럭.
            Queue<int> bridge = new Queue<int>();
            // 대기 트럭.
            Stack<int> trucks = new Stack<int>();


            for (int i = 0; i < truck_weights.Length; i++)
            {
                trucks.Push(truck_weights[truck_weights.Length - 1 - i]);
            }

            // 다리를 지난 트럭과 대기 트럭의 갯수가 같아질 때 까지 반복.
            while (passedTruck!=truck_weights.Length)
            {
                // 트럭을 꺼내야 하는 상태.
                if (bridge.Count == bridge_length)
                {
                    // 다리를 지난 트럭.
                    truck = bridge.Dequeue();
                    if (truck != 0)
                    {
                        nowWeight -= truck;
                        passedTruck++;
                    }
                }

                // 스택에서 다음 트럭을 꺼내본다.
                if (trucks.Count > 0)
                {
                    truck = trucks.Pop();
                }

                // 트럭을 올릴 수 있는지 확인한다.
                if (nowWeight + truck <= weight)
                {
                    // 무게 남아서 트럭 다리에 올리기.
                    bridge.Enqueue(truck);
                    entireTime++;
                    nowWeight += truck;
                }
                else
                {
                    // 무게 초과로 대기.
                    // 못올라간 자리엔 0이 들어간다.
                    bridge.Enqueue(0);
                    // 꺼냈던 트럭을 스택에 다시 넣는다.
                    trucks.Push(truck);
                    entireTime++;
                }
            }

            return entireTime;
        }

        #endregion


    }

}
