# Xamarin.Forms 2018 Couse Sample

課程說明
以往想要開發原生行動應用程式，您必須要遵循每個平台的SDK規範與了解應用程式的生命週期，並且使用專屬程式語言與API使用方式，例如： iOS 需要學習 Swift或者Objective-C，而 Android 必須要學習 Java，這使得想要開發一套能夠在不同行動裝置下運行的應用程式，您必須學習與精通這些開發工具與程式語言；最重要的是，不論是視覺介面 UI 或者商業邏輯程式碼，都無法跨平台共用，也就是說，同樣的商業邏輯需要使用不同程式語言重覆再寫一次。  

Xamarin.Forms 使用 .NET C# 程式語言，配合豐富資源 BCL 與視覺宣告 XAML語言，搭配地表最強的程式開發工具 Visual Studio，讓您可以一次性開發出可以在 iOS & Android & UWP 下運行的行動裝置應用程式，不論是視覺介面與商業邏輯，開發者也只需要撰寫一次即可，就可以產生出在不同行動裝置下執行的應用程式。另外，Xamarin.Forms 特別適合用於開發企業內部的行動應用。  

本次課程包含超過4個小時的先修錄影課程、 一堂 1 小時的線上課程 與 五天共 35 小時的實體課程，將會帶領大家快速上手 Xamarin.Forms 開發工具，您將會認識 Xamarin 開發環境，了解使用 Xamarin.Forms 開發工具所會遇到問題與解決方法，學會 XAML 與 MVVM 開發和設計模式，實際動手做出可以跨平台執行的應用程式，並且學會整個 Xamarin.Forms 開發過程。

練習專案說明

Day1

|專案名稱|專案說明|
|-|-|
|XFFodyDBinding|資料綁定 Data Binding 的使用 Fody 套件|
|XFINPC|資料綁定 Data Binding 的自行建置 INotifyPropertyChanged
|XFMeasureScreen|手機螢幕實際與設計畫素測試專案
|XFNavi|加入 Properties
|XFNaviEvent|導航並且接收參數 相關事件
|XamarinFirst|資料綁定 Data Binding 的自行建置 INotifyPropertyChanged|
|XFPrismDBinding|資料綁定 Data Binding 的使用 Prism 提供的 BindableBase 類別|
|||

[Day1 課後作業](https://github.com/vulcanlee/Xamarin170704/blob/master/Homework%20Day1.md)

Day2

|專案名稱|專案說明|
|-|-|
|XFCanExecute|命令是否可以執行的綁定|
|XFCommand|命令綁定與參數|
|XFDI|自訂可注入相依物件|
|XFDeepLink|練習情境 深度導航|
|XFDialog|Prism選擇項目之對話窗|
|XFNaviPara|頁面導航且傳遞引數|
|XFNaviPara1|頁面導航且傳遞引數(有 GoBackAsync傳遞參數練習)|
|XFPageEvent|子頁面傳回訊息回父頁面|
|XFPrismNavigation|頁面導航(不透過導航頁面)|
|XFSimpleNavigation|頁面導航(透過導航頁面)|
|XFEventCmd|Prism EventToCommandBehavior|
|XFPageEvent|子頁面傳回訊息回父頁面|
|XFNaviParaCB|頁面導航且傳遞引數 (後置碼)|
|XFRemovePage|Xamarin.Forms 的頁面導航之導航堆疊頁面移除，直接返回上上一頁|
|XFDeepLink|練習情境 深度導航|
|XFDialogCB|選擇項目之對話窗 (後置碼)|
|XFToolbarItem|導航工具列按鈕練習|
|XFNavigationTitle|不同系統平台下，導航頁面的返回按鈕文字問題(試著執行看看問題在哪裡)|
|NavigationPagePrism|透過 Icommand 資料綁定，自動啟用/停用按鈕(查看原始碼，看看如何做出這樣效果)|
|XFMasterDetail|導航抽屜頁面導航|
|XFTabbed|標籤式頁面之外部 XAML 檔案|
|XFCustVM|自訂ViewModel類別練習|
|XFDynamicMenu|動態兩階功能表練習|

[Day2 課後作業](https://github.com/vulcanlee/Xamarin170704/blob/master/Homework%20Day2.md)

Day3

|專案名稱|專案說明|
|-|-|
|XFLayoutOptions|版面配置選項 LayoutOptions對齊 / 延伸 展示範例，供學員執行看看結果|
|XFStackOption|StackLayout 的 Fill 與 FillAndExpand的差異|
|XAMLSamples|XAML版面配置與控制項範例(Charles Petzold 書中範例，請嘗試執行與查看原始碼)|
|XFGrid|Grid 版面配置練習，要設計出RWD效果的頁面|
|XFStackLayout|StackLayout 版面配置練習，了解集合資料綁定的個別項目的指定用法|
|XFViewHidden|動態顯示/隱藏控制項(按鈕的文字也會隨著狀態而有所變動)|
|XFScrollView|ScrollView 版面配置練習|
|XFRelLayout|RelativeLayout Layout|
|XFAbsLayout|AbsoluteLayout Layout|
|XFContentView|使用 ContentView 組合新控制項|
|XFEntry|單行文字輸入盒 Entry|
|XFWebListView|讀取顯示網路集合資料|
|XFWebListViewWV|讀取顯示網路集合資料，有將 HTML 文字使用 WebView 來顯示|
|XFListView|集合資料CRUD 顯示資料|
|XFListView1|集合資料CRUD 模擬情境|
|XFListView2|集合資料CRUD 修改與更新|
|XFListView3|集合資料CRUD 新增記錄|
|XFListView4|集合資料CRUD 點選刪除|
|XFMulSelLV|Xamarin.Forms ListView 集合資料多選|
|XFSchedule|挑戰做出好看的頁面|
|XFCustFont|進階應用 Font Awesome|
|XFIconize|使用Iconize套件，顯示圖示圖片|
|XFCorelPicker|可綁定Picker的連動練習|
|XFCorelPicker2|可綁定Picker的連動練習-次清單內容可保留|
|XFImageAspect|Image 控制項之 Aspect 效果測試|
|XFImage|Image 控制項的功能與特色圖片來源的使用方式/大小與定位問題|
|XFImageMask|顯示具有圓形遮罩 Mask 的圖片|
|XFBindingContext|追蹤頁面項目的 BindingContext|
|XFDisBack|停用軟體與硬體回上頁按鈕|
|XFCtrlTemplate|控制項樣板之應用(客製化 ContentPage頁面)|
|||

[Day3 課後作業](https://github.com/vulcanlee/Xamarin170704/blob/master/Homework%20Day3.md)

Day4

|專案名稱|專案說明|
|-|-|
|XFUserControl|Xamarin.Forms 使用者控制項展示範例(XAML 設計方法說明進階設計準則)|
|XFStatRes|XAML 靜態資源的使用|
|XFDynaRes|XAML 動態資源的使用|
|XFResInheritance|XAML 資源字典項目與繼承|
|XFStyle|XAML 的 樣式 style 應用(線上練習)|
|MergedDict|XAML 的 樣式 style 應用(用於參考各種不同的樣式用法與檢測在不同情境下發生的應用情況)|
|XFStyleEmu|儲存帳密的資源/樣式綜合演練(線上測驗，請學員線上實際開發出來)|
|XFxArray|x:Array 使用範例|
|XFValueConverter|數值轉換器 Value Converter|
|XFTransforms|XAML 轉換 (Transforms)|
|XFBindProp|可綁定屬性 Bindable Properties|
|XFAttBehavior|附加行為 Behaviors 應用(Attached Behaviors)，可以綁定與卸載控制項的事件|
|XFFormBehavior|Xamarin.Forms 行為 Behaviors 應用(Xamarin.Forms Behaviors)，可以綁定與卸載控制項的事件|
|XFAttProp|附加屬性 Attached Properties|
|XFAttPropEnum|附加屬性 Attached Properties，附加屬性值為列舉|
|XFCustPicker|客製化控制項Custom Control(研究如何繼承原有 Picker 控制項，接著，進行客製設計，產生一個新的控制項出來|
|XFTempSel|聊天室 DataTemplateSelector|
|XFGesPan|手勢移動區塊操作 GestureRecognizer|
|XFAnimation|動畫 Animations|
|XFDataVerify|使用者輸入資料驗證應用|
|XFTriggerDemo|觸發 Trigger 的各種不同使用展示|
|XFTrigger|使用者登入與觸發應用(多重觸發 Multi Trigger)|
|XFRendCtrl|進行 Entry 控制項客製化(Renderer)|
|XFEntryVerify|使用者控制項 User Control 綜合練習，輸入正確格式文字，會有提示視覺出現|
|XFEllipseView|客製+使用者控制項綜合應用|
|XFUserPanel|客製按鈕面板應用 2(雙層使用者控制項與 BindingContext 練習)|
|XFConvertBack|數值轉換器 ConvertBack|
|XFMoreGesture|擴充其他手勢操作|

[Day4 課後作業](https://github.com/vulcanlee/Xamarin170704/blob/master/Homework%20Day4.md)

HW : XFVisualTree 設計一個輔助除錯的附加屬性；可以隨時得知當時的VisualElement 的 BindingContext 是甚麼類型的物件；另外，可以查看這個 Element 的繼承階層架構。

Day5

|專案名稱|專案說明|
|-|-|
|XFFiles|檔案存取與使用|
|XFAppProp|使用 Properties 來儲存到手機上|
|XFPCLFile|使用 PCLStorage 儲存到手機上|
|||
|||
|||
|||
|||

[Day5 課後作業](https://github.com/vulcanlee/Xamarin170704/blob/master/Homework%20Day5.md)

[![I ♥ Xamarin](https://4.bp.blogspot.com/-hS_XgJO3OGg/Wq0Gn0kPU2I/AAAAAAAANKs/G-SXFj-evrE8lGdcicWv7SC3-f6wyi4sgCEwYBhgL/s320/ILoveXamarin.png)](https://mylabtw.blogspot.com)

[Xamarin 實驗室 部落格](http://mylabtw.blogspot.com/) 是作者本身的部落格，這個部落格將會專注於 Xamarin 之跨平台 (Android / iOS / UWP) 方面的各類開技術探討、研究與分享的文章，最重要的是，它是全繁體中文。
