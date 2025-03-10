﻿using Assets.Common.Scripts.Datas.UIData;
using Common.Data;
using Common.Settings;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///普通累積儲值資料頁面
/// </summary>
public class ComPurchaseLongTermImp : ComPurchaseDailyImp
{
    public override DepositEventType DepositUIType { get { return DepositEventType.PurchaseWeekly; } }

    public override bool IsDaily { get { return false; } }
    #region Banner Area
    /// <summary>
    /// 累積儲值 字串
    /// </summary>
    public override string BannerTittle { get { return PBSettingsV3.String[22003].Msg; } }

    #endregion

    #region 中間橫槓區域
    /// <summary>
    /// 累積儲值金額標題 - 字串
    /// </summary>
    public override string AccumulatedTitle { get { return PBSettingsV3.String[22017].Msg; } }
   

    #endregion

    public override string ScrollItemTitle { get { return PBSettingsV3.String[22013].Msg; } }

}
