using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Coffee.UIEffects;
using UnityEngine;
using UnityEngine.UI;
using XCharts.Runtime;
using DG.Tweening;
using Random = UnityEngine.Random;

public class MainMenuContrl : MonoBehaviour
{
   public GameObject ChuNengLIneXCharts;
   public GameObject YQBGYDQKXCharts;
   public GameObject YWFHXCharts;

   //光伏运行监控
   public GameObject GuangFuJKMenu_TitleBg;
   public GameObject GuangFuJKMenu_GFItem;
   public GameObject GuangFuJKMenu_MaskBg;
   public Text GuangFuJKMenu_ZJRL_Value;
   public Text GuangFuJKMenu_SSFD_Value;
   public Text GuangFuJKMenu_DRFDL_Value;
   public Text GuangFuJKMenu_DYFDL_Value;
   public Text GuangFuJKMenu_DNFDL_Value;
   public Text GuangFuJKMenu_LJFDL_Value;
   public Image GuangFuJKMenu_DRFDL_Value_Image;
   public Image GuangFuJKMenu_DYFDL_Value_Image;
   public Image GuangFuJKMenu_DNFDL_Value_Image;
   public Image GuangFuJKMenu_LJFDL_Value_Image;
   public GameObject GuangFuJKMenu_BtnItem;

   //储能运行监控
   public GameObject ChuNengJKMenu_TitleBg;
   public GameObject ChuNengJKMenu_GFItem;
   public Image ChuNengJKMenu_FangDian_Value;
   public Text ChuNengJKMenu_FangDian_Value2;
   public Text ChuNengJKMenu_FangDian_Value3;
   public GameObject ChuNengJKMenu_MaskBg;
   public Text ChuNengJKMenu_ZongChongDian_Value;
   public Text ChuNengJKMenu_ZongFangDian_Value;

   //环保贡献
   public GameObject HuanBaoGXMenu_TitleBg;
   public GameObject HuanBaoGXMenu_BtnItem;
   public GameObject HuanBaoGXMenu_MaskBg;
   public Text HuanBaoGXMenu_JSERHTPFL_Value;
   public Text HuanBaoGXMenu_JBML_Value;
   public Text HuanBaoGXMenu_JSEYHSPFL_Value;
   public Text HuanBaoGXMenu_JSSLKFSL_Value;

   //园区办公用电情况
   public GameObject YuanQuBGMenu_TitleBg;
   public GameObject YuanQuBGMenu_BtnItem;
   public GameObject YuanQuBGMenu_MaskBg;
   public Text YuanQuBGMenu_DRYDL_Value;
   public Text YuanQuBGMenu_LJYDL_Value;

   //源网荷储
   public GameObject YuanWangFHMenu_TitleBg;
   public GameObject YuanWangFHMenu_BtnItem;
   public GameObject YuanWangFHMenu_MaskBg;

   //空调运行监控
   public GameObject KongTiaoYXJKMenu_TitleBg;
   public GameObject KongTiaoYXJKMenu_BtnItem;
   public GameObject KongTiaoYXJKMenu_MaskBg;
   public Image KongTiaoYXJKMenu_KTYXTJ_Value_Img;
   public Text KongTiaoYXJKMenu_KTYXTJ_Value;
   public Text KongTiaoYXJKMenu_KTYXDJ_Value;
   public Text KongTiaoYXJKMenu_SSFH_Value;
   public Text KongTiaoYXJKMenu_JRZDFH_Value;
   public Text KongTiaoYXJKMenu_JRYDL_Value;
   public Text KongTiaoYXJKMenu_ZRYDL_Value;
   public Image KongTiaoYXJKMenu_JRZLDZB_Value_Img;
   public Text KongTiaoYXJKMenu_JRZLDZB_Value;
   public Image KongTiaoYXJKMenu_LJZLDZB_Value_Img;
   public Text KongTiaoYXJKMenu_LJZLDZB_Value;

   //绿色出行
   public GameObject LvSeCXMenu_TitleBg;
   public GameObject LvSeCXMenu_BtnItem;
   public GameObject LvSeCXMenu_MaskBg;
   public Text LvSeCXMenu_QCCDZ_Value;
   public Text LvSeCXMenu_DDCCDZ_Value;
   public Text LvSeCXMenu_JRZYDL_Value;
   public Text LvSeCXMenu_LJZYDL_Value;
   public Text LvSeCXMenu_SSGL_Value;

   //风行机运行监控
   public GameObject FengJiYXMenu_TitleBg;
   public GameObject FengJiYXMenu_BtnItem;
   public GameObject FengJiYXMenu_MaskBg;
   public Text ZJRL_Value;
   public Text SSFD_Value;
   public Image DRFDL_Value_Img;
   public Image DYFDL_Value_Img;
   public Image DNFDL_Value_Img;
   public Image LJFDL_Value_Img;
   public Text DRFDL_Value;
   public Text DYFDL_Value;
   public Text DNFDL_Value;
   public Text LJFDL_Value;


   private void Awake()
   {
      //光伏运行监控
      GuangFuJKMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 50), 0);
      GuangFuJKMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-939, 409), 0);
      GuangFuJKMenu_GFItem.transform.DOLocalMoveY(31, 0, false);
      GuangFuJKMenu_MaskBg.GetComponent<Image>().DOFade(0.1f, 0);
      GuangFuJKMenu_BtnItem.transform.DOScale(new Vector3(0, 0, 0), 0);

      //储能运行监控
      ChuNengJKMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(-0.51f, 50), 0);
      ChuNengJKMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-941, 67), 0);
      ChuNengJKMenu_GFItem.transform.DOLocalMoveY(440, 0, false);
      ChuNengJKMenu_MaskBg.GetComponent<Image>().DOFade(0.1f, 0);

      //环保贡献
      HuanBaoGXMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 50), 0);
      HuanBaoGXMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-940, -328), 0);
      HuanBaoGXMenu_BtnItem.transform.DOLocalMoveY(561, 0, false);
      HuanBaoGXMenu_MaskBg.GetComponent<Image>().DOFade(0.1f, 0);

      //园区办公用电情况
      YuanQuBGMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 0.5f), 0);
      YuanQuBGMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-235, -232), 0);
      YuanQuBGMenu_BtnItem.transform.DOLocalMoveY(116, 0, false);
      YuanQuBGMenu_MaskBg.GetComponent<Image>().DOFade(0.1f, 0);

      //源网荷储
      YuanWangFHMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 0.5f), 0);
      YuanWangFHMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(234, -234), 0);
      YuanWangFHMenu_BtnItem.transform.DOLocalMoveY(141, 0, false);
      YuanWangFHMenu_MaskBg.GetComponent<Image>().DOFade(0.1f, 0);

      //空调运行监控
      KongTiaoYXJKMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 50), 0);
      KongTiaoYXJKMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(940, -163), 0);
      KongTiaoYXJKMenu_BtnItem.transform.DOLocalMoveY(37, 0, false);
      KongTiaoYXJKMenu_MaskBg.GetComponent<Image>().DOFade(0.1f, 0);

      //绿色出行
      LvSeCXMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 50), 0);
      LvSeCXMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(941, 66), 0);
      LvSeCXMenu_BtnItem.transform.DOLocalMoveY(-108, 0, false);
      LvSeCXMenu_MaskBg.GetComponent<Image>().DOFade(0.1f, 0);

      //风行机运行监控
      FengJiYXMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(0, 50), 0);
      FengJiYXMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-482, 409), 0);
      FengJiYXMenu_BtnItem.transform.DOLocalMoveY(-496, 0, false);
      FengJiYXMenu_MaskBg.GetComponent<Image>().DOFade(0.1f, 0);
   }

   public IEnumerator Start()
   {
      //光伏运行监控
     GuangFuJKMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 50), 1).SetEase(Ease.Linear);
      GuangFuJKMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-711, 409), 1).SetEase(Ease.Linear);
     GuangFuJKMenu_MaskBg.GetComponent<Image>().DOFade(1, 0.5f);
      GuangFuJKMenu_GFItem.transform.DOLocalMoveY(-232, 0.5f, false).SetDelay(0.3f).SetEase(Ease.Linear);
      GuangFuJKMenu_BtnItem.transform.DOScale(new Vector3(1, 1, 1), 0.5f).SetEase(Ease.Linear);

      //储能运行监控
      ChuNengJKMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 50), 1).SetEase(Ease.Linear);
      ChuNengJKMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-712, 67), 1).SetEase(Ease.Linear);
      ChuNengJKMenu_GFItem.transform.DOLocalMoveY(128, 0.5f, false).SetDelay(0.3f).SetEase(Ease.Linear);
      ChuNengJKMenu_MaskBg.GetComponent<Image>().DOFade(1, 0.5f);

      //环保贡献
      HuanBaoGXMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 50), 1).SetEase(Ease.Linear);
      HuanBaoGXMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-712, -328), 1).SetEase(Ease.Linear);
      HuanBaoGXMenu_BtnItem.transform.DOLocalMoveY(431, 0.5f, false).SetDelay(0.3f).SetEase(Ease.Linear);
      HuanBaoGXMenu_MaskBg.GetComponent<Image>().DOFade(1, 0.5f);

      //园区办公用电情况
      YuanQuBGMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 50), 1).SetEase(Ease.Linear);
      YuanQuBGMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-235, -208), 1).SetEase(Ease.Linear);
      YuanQuBGMenu_BtnItem.transform.DOLocalMoveY(375, 0.5f, false).SetDelay(0.3f).SetEase(Ease.Linear);
      YuanQuBGMenu_MaskBg.GetComponent<Image>().DOFade(1, 0.5f);

      //源网荷储
      YuanWangFHMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 50), 1).SetEase(Ease.Linear);
      YuanWangFHMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(234, -209), 1).SetEase(Ease.Linear);
      YuanWangFHMenu_BtnItem.transform.DOLocalMoveY(370, 0.5f, false).SetDelay(0.3f).SetEase(Ease.Linear);
      YuanWangFHMenu_MaskBg.GetComponent<Image>().DOFade(1, 0.5f);

      //空调运行监控
      KongTiaoYXJKMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 50), 1).SetEase(Ease.Linear);
      KongTiaoYXJKMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(712, -163), 1)
         .SetEase(Ease.Linear);
      KongTiaoYXJKMenu_BtnItem.transform.DOLocalMoveY(348, 0.5f, false).SetDelay(0.3f).SetEase(Ease.Linear);
      KongTiaoYXJKMenu_MaskBg.GetComponent<Image>().DOFade(1, 0.5f);

      //绿色出行
      LvSeCXMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 50), 1).SetEase(Ease.Linear);
      LvSeCXMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(712, 66), 1).SetEase(Ease.Linear);
      LvSeCXMenu_BtnItem.transform.DOLocalMoveY(46, 0.5f, false).SetDelay(0.3f).SetEase(Ease.Linear);
      LvSeCXMenu_MaskBg.GetComponent<Image>().DOFade(1, 0.5f);

      //风行机运行监控
      FengJiYXMenu_TitleBg.GetComponent<RectTransform>().DOSizeDelta(new Vector2(457, 50), 1).SetEase(Ease.Linear);
      FengJiYXMenu_TitleBg.GetComponent<RectTransform>().DOAnchorPos(new Vector2(-711, 409), 1).SetEase(Ease.Linear);
      FengJiYXMenu_BtnItem.transform.DOLocalMoveY(-232, 0.5f, false).SetDelay(0.3f).SetEase(Ease.Linear);
      FengJiYXMenu_MaskBg.GetComponent<Image>().DOFade(1, 0.5f);

      ChuNengFHXChartsData();
      YQBGYDQKXChartsData();
      YWFHXChartsData();

      yield return new WaitForSeconds(5f);

      StartCoroutine(GuangFuJKMenu_DataInit());
      StartCoroutine(ChuNengJKMenu_DataInit());
      StartCoroutine(HuanBaoGXMenu_DataInit());
      StartCoroutine(YuanQuBGMenu_DataInit());
      StartCoroutine(YuanWangFHMenu_DataInit());
      StartCoroutine(KongTiaoYXJKMenu_DataInit());
      StartCoroutine(LvSeCXMenu_DataInit());
      StartCoroutine(FengJiYXMenu_DataInit());
   }

   //光伏运行监控 数据
   public IEnumerator GuangFuJKMenu_DataInit()
   {
      MoveToTextNumContrl(GuangFuJKMenu_ZJRL_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<color=#FFFFFF><size=16> kWp</size></color>");
      MoveToTextNumContrl(GuangFuJKMenu_SSFD_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<color=#FFFFFF><size=16> kW</size></color>");

      MoveToTextNumContrl(GuangFuJKMenu_DRFDL_Value, Random.Range(1, 100), Random.Range(1, 100), "");
      MoveToTextNumContrl(GuangFuJKMenu_DYFDL_Value, Random.Range(1, 100), Random.Range(1, 100), "");
      MoveToTextNumContrl(GuangFuJKMenu_DNFDL_Value, Random.Range(1, 100), Random.Range(1, 100), "");
      MoveToTextNumContrl(GuangFuJKMenu_LJFDL_Value, Random.Range(1, 100), Random.Range(1, 100), "");

      MoveToSilderContrl(GuangFuJKMenu_DRFDL_Value_Image, Random.Range(0.1f, 1.0f));
      MoveToSilderContrl(GuangFuJKMenu_DYFDL_Value_Image, Random.Range(0.1f, 1.0f));
      MoveToSilderContrl(GuangFuJKMenu_DNFDL_Value_Image, Random.Range(0.1f, 1.0f));
      MoveToSilderContrl(GuangFuJKMenu_LJFDL_Value_Image, Random.Range(0.1f, 1.0f));

      yield return new WaitForSeconds(5f);

      StartCoroutine(GuangFuJKMenu_DataInit());

   }

   //储能运行监控
   public IEnumerator ChuNengJKMenu_DataInit()
   {
      MoveToSilderContrl(ChuNengJKMenu_FangDian_Value, Random.Range(0.1f, 1.0f));
      MoveToTextNumContrl(ChuNengJKMenu_FangDian_Value2, Random.Range(1, 100), Random.Range(1, 100), "%");
      MoveToTextNumContrl(ChuNengJKMenu_FangDian_Value3, Random.Range(1, 100), Random.Range(1, 100),
         "<color=#FFFFFF><size=20> kW</size></color>");

      MoveToTextNumContrl(ChuNengJKMenu_ZongChongDian_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<color=#FFFFFF><size=16> kWh</size></color>");
      MoveToTextNumContrl(ChuNengJKMenu_ZongFangDian_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<color=#FFFFFF><size=16> kWh</size></color>");

      yield return new WaitForSeconds(5f);

      ChuNengFHXChartsData();
      StartCoroutine(ChuNengJKMenu_DataInit());
   }

   //环保贡献
   public IEnumerator HuanBaoGXMenu_DataInit()
   {
      MoveToTextNumContrl(HuanBaoGXMenu_JSERHTPFL_Value, Random.Range(1, 100), Random.Range(100, 3000), "");
      MoveToTextNumContrl(HuanBaoGXMenu_JBML_Value, Random.Range(1, 100), Random.Range(1, 300), "");
      MoveToTextNumContrl(HuanBaoGXMenu_JSEYHSPFL_Value, Random.Range(1, 100), Random.Range(100, 3000), "");
      MoveToTextNumContrl(HuanBaoGXMenu_JSSLKFSL_Value, Random.Range(1, 100), Random.Range(1, 300), "");

      yield return new WaitForSeconds(5f);

      StartCoroutine(HuanBaoGXMenu_DataInit());

   }

   //园区办公用电情况
   public IEnumerator YuanQuBGMenu_DataInit()
   {
      MoveToTextNumContrl(YuanQuBGMenu_DRYDL_Value, Random.Range(1, 100), Random.Range(100, 300),
         "<color=#FFFFFF><size=20> kWh</size></color>");
      MoveToTextNumContrl(YuanQuBGMenu_LJYDL_Value, Random.Range(1, 100), Random.Range(1000, 2000),
         "<color=#FFFFFF><size=20> kWh</size></color>");

      yield return new WaitForSeconds(5f);
      YQBGYDQKXChartsData();
      StartCoroutine(YuanQuBGMenu_DataInit());

   }

   //源网荷储
   public IEnumerator YuanWangFHMenu_DataInit()
   {
      yield return new WaitForSeconds(5f);
      YWFHXChartsData();
      StartCoroutine(YuanWangFHMenu_DataInit());
   }

   //空调运行监控
   public IEnumerator KongTiaoYXJKMenu_DataInit()
   {

      MoveToSilderContrl(KongTiaoYXJKMenu_KTYXTJ_Value_Img, Random.Range(0.1f, 1.0f));
      MoveToTextNumContrl(KongTiaoYXJKMenu_KTYXTJ_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<size=12>%</size>");
      MoveToTextNumContrl(KongTiaoYXJKMenu_KTYXDJ_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<size=12>%</size>");

      MoveToTextNumContrl(KongTiaoYXJKMenu_SSFH_Value, Random.Range(100, 500), Random.Range(100, 500), "kW");
      MoveToTextNumContrl(KongTiaoYXJKMenu_JRZDFH_Value, Random.Range(100, 500), Random.Range(100, 500), "kW");
      MoveToTextNumContrl(KongTiaoYXJKMenu_JRYDL_Value, Random.Range(100, 500), Random.Range(100, 500), "kWh");
      MoveToTextNumContrl(KongTiaoYXJKMenu_ZRYDL_Value, Random.Range(100, 500), Random.Range(100, 500), "kWh");

      MoveToSilderContrl(KongTiaoYXJKMenu_JRZLDZB_Value_Img, Random.Range(0.1f, 1.0f));
      MoveToTextNumContrl(KongTiaoYXJKMenu_JRZLDZB_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<size=12> %</size>");

      MoveToSilderContrl(KongTiaoYXJKMenu_LJZLDZB_Value_Img, Random.Range(0.1f, 1.0f));
      MoveToTextNumContrl(KongTiaoYXJKMenu_LJZLDZB_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<size=12> %</size>");

      yield return new WaitForSeconds(5f);

      StartCoroutine(KongTiaoYXJKMenu_DataInit());
   }

   //绿色出行
   public IEnumerator LvSeCXMenu_DataInit()
   {
      MoveToTextNumContrl(LvSeCXMenu_QCCDZ_Value, Random.Range(1, 100), Random.Range(1, 100),"");
      MoveToTextNumContrl(LvSeCXMenu_DDCCDZ_Value, Random.Range(1, 100), Random.Range(1, 100), "");

      MoveToTextNumContrl(LvSeCXMenu_JRZYDL_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<color=#FFFFFF><size=16>kWh</size></color>");
      MoveToTextNumContrl(LvSeCXMenu_LJZYDL_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<color=#FFFFFF><size=16>kWh</size></color>");
      MoveToTextNumContrl(LvSeCXMenu_SSGL_Value, Random.Range(1, 100), Random.Range(1, 100),
         "<color=#FFFFFF><size=16>kW</size></color>");

      yield return new WaitForSeconds(5f);

      StartCoroutine(LvSeCXMenu_DataInit());
   }

   //风行机运行监控
   public IEnumerator FengJiYXMenu_DataInit()
   {
      MoveToTextNumContrl(ZJRL_Value, Random.Range(1, 100), Random.Range(1, 100), "<color=#FFFFFF><size=16>  kWp</size></color>");
      MoveToTextNumContrl(SSFD_Value, Random.Range(1, 100), Random.Range(1, 100), "<color=#FFFFFF><size=16>  kW</size></color>");
      
      MoveToSilderContrl(DRFDL_Value_Img, Random.Range(0.1f, 1.0f));
      MoveToSilderContrl(DYFDL_Value_Img, Random.Range(0.1f, 1.0f));
      MoveToSilderContrl(DNFDL_Value_Img, Random.Range(0.1f, 1.0f));
      MoveToSilderContrl(LJFDL_Value_Img, Random.Range(0.1f, 1.0f));
      
      MoveToTextNumContrl(DRFDL_Value, Random.Range(200, 400), Random.Range(200, 400), "");
      MoveToTextNumContrl(DYFDL_Value, Random.Range(400, 900), Random.Range(400, 900), "");
      MoveToTextNumContrl(DNFDL_Value, Random.Range(1000, 3000), Random.Range(1000, 3000), "");
      MoveToTextNumContrl(LJFDL_Value, Random.Range(4000, 6000), Random.Range(4000, 6000), "");
      
      yield return new WaitForSeconds(5f);

      StartCoroutine(FengJiYXMenu_DataInit());
   }

   private void MoveToTextNumContrl(Text currentText, int minNum, int maxNum, string DW)
   {
      DOTween.To(value => { currentText.text = Mathf.Floor(value).ToString() + DW; }, startValue: minNum, endValue: maxNum, duration: 0.5f).SetEase(Ease.Linear);
   }

   public void MoveToSilderContrl(Image currentImg,float currentNum)
   {
      
      DOTween.To(() => currentImg.fillAmount, x => currentImg.fillAmount = x, currentNum, 0.5f);
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.A))
      {
         Awake();
      }

      if (Input.GetKeyDown(KeyCode.B))
      {
         StartCoroutine(Start());
      }
   }

   //储能负荷运行监控 曲线图 
   public void ChuNengFHXChartsData()
   {
      var chart = ChuNengLIneXCharts.GetComponent<LineChart>();
      chart.ClearData();
      
      var xAxis = chart.GetOrAddChartComponent<XAxis>();
      xAxis.splitNumber = 5;
      
      var yAxis = chart.GetOrAddChartComponent<YAxis>();
      yAxis.type =  Axis.AxisType.Value;
      
      for (int i = 0; i < 5; i++)
      {
         chart.AddXAxisData( "测试" + i.ToString());
         chart.AddData(0, Random.Range(5,30));
      }
   }
   
   //园区办公用电情况 曲线图
   public void YQBGYDQKXChartsData()
   {
      var chart = YQBGYDQKXCharts.GetComponent<LineChart>();
      chart.ClearData();
      
      var xAxis = chart.GetOrAddChartComponent<XAxis>();
      xAxis.splitNumber = 5;
      
      var yAxis = chart.GetOrAddChartComponent<YAxis>();
      yAxis.type =  Axis.AxisType.Value;
      
      
      for (int i = 0; i < 5; i++)
      {
         chart.AddXAxisData("测试" + i.ToString());
         chart.AddData(0, Random.Range(10,30));
         chart.AddData(1, Random.Range(10,30));
      }
   }
   
   //源网荷储 曲线图
   public void YWFHXChartsData()
   {
      var chart = YWFHXCharts.GetComponent<LineChart>();
      chart.ClearData();
      
      var xAxis = chart.GetOrAddChartComponent<XAxis>();
      xAxis.splitNumber = 5;
      
      var yAxis = chart.GetOrAddChartComponent<YAxis>();
      yAxis.type =  Axis.AxisType.Value;
      
      
      for (int i = 0; i < 5; i++)
      {
         chart.AddXAxisData("测试" + i.ToString());
         chart.AddData(0, Random.Range(10,30));
         chart.AddData(1, Random.Range(10,30));
         chart.AddData(2, Random.Range(10,30));
         chart.AddData(3, Random.Range(10,30));
      }
   }
}
