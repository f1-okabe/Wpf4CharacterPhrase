using _4CharacterPhrase;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace Wpf4CharacterPhrase
{
    public class CellStatusToBackgroundConverter : IValueConverter
    {
        /// <summary>
        /// bool型を"はい"または"いいえ"に変換するメソッド
        /// </summary>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 変換元データを変数に受け取る。
            var cellStatus = (CellStatus)value;

            switch (cellStatus) 
            {
                case CellStatus.None:
                    return new SolidColorBrush(Colors.White);
                case CellStatus.Selected:
                    return new SolidColorBrush(Colors.SkyBlue);
                case CellStatus.Completed:
                    return new SolidColorBrush(Colors.DimGray);
                default:
                    return new SolidColorBrush(Colors.White);
            }
        }

        /// <summary>
        /// "はい"または"いいえ"をbool型に逆変換するメソッド
        /// 定義しない場合は return null; だけでOK
        /// </summary>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
            //// 変換元データを変数に受け取る。
            //var inputString = value as string;

            //// 変換後のデータを返す。
            //switch (inputString)
            //{
            //    case "はい":
            //        return true;
            //    case "いいえ":
            //        return false;
            //    default:
            //        return Binding.DoNothing;
            //}
        }
    }
}
