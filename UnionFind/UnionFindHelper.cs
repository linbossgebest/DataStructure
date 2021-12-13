using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    /// <summary>
    /// 构造一个并查集基本结构
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Element<T>
    {
        public T Value { get; set; }

        public Element(T t)
        {
            this.Value = t;
        }
    }

    /// <summary>
    /// 并查集使用
    /// </summary>
    public class UnionFindHelper<T>
    {
        public Dictionary<T, Element<T>> elementDic; //元素包装字典
        public Dictionary<Element<T>, Element<T>> fatherDic;//父结构字典
        public Dictionary<Element<T>, int> sizeDic;//元素大小字典

        /// <summary>
        /// 构造器初始化数据 
        /// a  b  c  d  e
        ///{a}{b}{c}{d}{e}
        ///elementDic a:{a} b:{b} c:{c} d:{d} e:{e}
        ///fatherDic {a}:{a} {b}:{b} {c}:{c} {d}:{d} {e}:{e}
        ///sizeDic   {a}:1   {b}:1   {c}:1   {d}:1   {e}:1
        /// </summary>
        /// <param name="list"></param>
        public UnionFindHelper(List<T> list)
        {
            elementDic = new Dictionary<T, Element<T>>();
            fatherDic = new Dictionary<Element<T>, Element<T>>();
            sizeDic = new Dictionary<Element<T>, int>();
            foreach (var item in list)
            {
                var elementItem = new Element<T>(item);
                elementDic.Add(item, elementItem);
                fatherDic.Add(elementItem, elementItem);
                sizeDic.Add(elementItem, 1);
            }
        }

        /// <summary>
        /// 查找元素的最上父节点
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private Element<T> FindHead(Element<T> element)
        {
            Stack<Element<T>> pathStack = new Stack<Element<T>>();
            while (element != fatherDic[element])
            {
                pathStack.Push(element);
                element = fatherDic[element];
            }
            while (pathStack.Count > 0)//数据扁平化处理，让子节点都直接指向最上节点
            {
                var popElement = pathStack.Pop();
                fatherDic[popElement] = element;
            }
            return element;
        }

        /// <summary>
        /// 判断是否在同一个集合中
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public bool IsSameUnion(T a, T b)
        {
            if (elementDic.ContainsKey(a) && elementDic.ContainsKey(b))
            {
                if (FindHead(elementDic[a]) == FindHead(elementDic[b]))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// 两个元素做并集
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public void UnionData(T a, T b)
        {
            if (elementDic.ContainsKey(a) && elementDic.ContainsKey(b))
            {
                var elementA = FindHead(elementDic[a]);
                var elementB = FindHead(elementDic[b]);
                if (elementA != elementB)//两个元素已经是否在一个集合中
                {
                    var bigElement = sizeDic[elementA] >= sizeDic[elementB] ? elementA : elementB;
                    var smallElement = elementA == bigElement ? elementB : elementA;

                    fatherDic[smallElement] = bigElement;
                    sizeDic[bigElement] = sizeDic[bigElement] + sizeDic[smallElement];
                    sizeDic.Remove(smallElement);
                }                
            }
        }
    }
}
