﻿using GeekDesk.Constant;
using GeekDesk.ViewModel;
using System;
using System.Globalization;
using System.Windows.Data;

namespace GeekDesk.Converts
{
    /// <summary>
    /// 根据主窗口width 和传入类型  获取其它宽度
    /// </summary>
    class GetWidthByWWConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            WidthTypeEnum type = (WidthTypeEnum)parameter;

            AppConfig config = MainWindow.appData.AppConfig;

            if (WidthTypeEnum.LEFT_CARD == type)
            {
                return config.MenuCardWidth;
            }
            else if (WidthTypeEnum.RIGHT_CARD == type)
            {
                return config.WindowWidth - config.MenuCardWidth;
            } else if (WidthTypeEnum.RIGHT_CARD_HALF == type)
            {
                return (config.WindowWidth - config.MenuCardWidth) / 2;
            }

            return config.WindowWidth;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
