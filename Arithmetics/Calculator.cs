using System;
using System.Linq;
using System.Management.Automation;

namespace Arithmetics
{
    public class Calculator : IDisposable
    {
        private RunspaceInvoke _invoker;

        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public Calculator()
        {
            _invoker = new RunspaceInvoke();
        }

        /// <summary>
        /// 文字列の計算式を計算した結果を返す
        /// </summary>
        /// <param name="expression">計算式</param>
        /// <returns>計算結果</returns>
        public double Calculate(string expression)
        {
            string converted = Converter.Convert(expression);
            var result = _invoker.Invoke(converted)?.FirstOrDefault()?.BaseObject.ToString();
            return double.Parse(result);
        }

        public void Dispose()
        {
            _invoker.Dispose();
            _invoker = null;
        }
    }
}
