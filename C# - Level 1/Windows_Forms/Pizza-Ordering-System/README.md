# Pizza Restaurant Order Management System

[📑 اضغط هنا للانتقال إلى النسخة العربية](#نظام-إدارة-طلبات-مطعم-البيتزا)

This project is the first simple application I have built using Windows Forms graphical user interfaces. The system does not aim to be a massive or complex system, but rather a humble first step and a simple software simulation that mimics how functional systems operate in real-world restaurants in a smooth and direct manner. Its primary goal is to apply programming concepts and build a strong foundation in interactive interface design.

---

## Core System Features and Screen Sequence

* **Main Page:** The primary screen and the entry gateway to the system, from which you can navigate directly to the menu selection page or the restaurant information page.

* **About Us Page (Sub-page branching from the Main Page):** A distinct interface that displays the restaurant's vision and story to customers in an elegant visual style.

* **Smart Food Menu (Sub-page opening from the Main Page):** Allows precise selection of various pizza sizes, crust types, and dining locations. From here, users proceed to the custom toppings screen, and the price list screen also branches from this page.

<img width="1802" height="816" alt="Screenshot 2026-06-26 064059" src="https://github.com/user-attachments/assets/93d1bc9a-c219-40f5-8e53-9b9707f4f0ba" />

* **Updated Price List (Sub-page branching from the Menu and Sizes screen):** A dedicated screen to display prices clearly to ensure transparency with the customer and assist them in calculating the cost of the size before making a selection.

* **Custom Toppings Screen (Sub-page opening after selecting from the Menu):** Enables the selection of additional ingredients and calculates their costs automatically and instantly. Upon completion, it leads directly to the final invoice and summary screen.

<img width="1793" height="779" alt="Screenshot 2026-06-26 065640" src="https://github.com/user-attachments/assets/d23f57d3-dbea-4c67-be7e-f7c23b5d0c49" />

* **Order Summary and Confirmation (Sub-page opening after the Toppings screen):** A final review screen that accurately calculates the total and locks the order to prevent accidental modifications after confirmation, featuring an order reset capability to start a new process instantly by opening the menu again.

<img width="1669" height="890" alt="Screenshot 2026-06-26 064151" src="https://github.com/user-attachments/assets/871ccdde-4d70-4915-a7af-38b7ebb4e6d3" />

<img width="1653" height="866" alt="Screenshot 2026-06-26 071328" src="https://github.com/user-attachments/assets/4e8c6204-5e98-4043-93ba-dc3e4029b5f0" />


---

## Screen and File Hierarchy Within the System

Based on the software design of the project, the system is divided into a collection of interconnected interfaces:

* **MainPage:** The main screen and entry gateway to the system.
* **MenuePage:** The menu screen for selecting size, crust type, and dining location.
* **frmToppings:** The screen for controlling toppings and calculating total prices.
* **frmOrderSummary:** The final invoice, confirmation, and order reset screen.
* **frmPriceList:** The screen displaying the detailed price list.
* **AboutUsPage:** The screen displaying the restaurant's story and mission.

---

## Technologies Used

* **Programming Language:** C#
* **Development Environment:** Microsoft Visual Studio
* **Application Type and Operating System:** Graphical User Interfaces (Windows Forms App) built on .NET Framework

---
🚀 This system was developed as part of a software development journey and building advanced functional systems!

---

# نظام إدارة طلبات مطعم البيتزا

يعتبر هذا المشروع أول تطبيق بسيط أقوم ببنائه باستخدام واجهات المستخدم الرسومية للويندوز فورمس (Windows Forms). النظام لا يسعى ليكون نظاماً عملاقاً أو معقداً، بل هو خطوة أولى متواضعة ومحاكاة برمجية بسيطة تحاكي آلية عمل الأنظمة الوظيفية في المطاعم الحقيقية بشكل سلس ومباشر، وهدفه الأساسي هو تطبيق المفاهيم البرمجية وبناء الأساسات القوية في تصميم الواجهات التفاعلية.

---

## الميزات الأساسية للنظام وتسلسل الشاشات

* **الصفحة الرئيسية:** هي الشاشة الأساسية وبوابة الدخول للنظام، ومن خلالها يتم الانتقال مباشرة إلى صفحة اختيار قائمة الطعام أو صفحة التعريف بالمطعم.

* **صفحة التعريف بالمطعم (صفحة فرعية تتفرع من الشاشة الرئيسية):** واجهة مميزة تعرض رؤية المطعم وقصته للعملاء بأسلوب بصري راقٍ.

* **قائمة الطعام الذكية (صفحة فرعية تفتح من الشاشة الرئيسية):** تتيح اختيار أحجام البيتزا المختلفة، وأنواع العجائن بدقة، وتحديد مكان تناول الطعام، ومنها يتم الانتقال إلى شاشة الإضافات المخصصة، كما تتفرع منها شاشة عرض قائمة الأسعار.

<img width="1802" height="816" alt="Screenshot 2026-06-26 064059" src="https://github.com/user-attachments/assets/93d1bc9a-c219-40f5-8e53-9b9707f4f0ba" />

* **قائمة الأسعار المحدثة (صفحة فرعية تتفرع من شاشة قائمة الطعام والأحجام):** شاشة مخصصة لعرض الأسعار بوضوح لضمان الشفافية مع العميل ومساعدته في حساب تكلفة الحجم قبل الاختيار.

* **شاشة الإضافات المخصصة (صفحة فرعية تفتح بعد تحديد قائمة الطعام):** تتيح تحديد المكونات الإضافية وحساب تكاليفها بشكل تلقائي وفوري، وبعد الانتهاء منها يتم الانتقال مباشرة إلى شاشة الفاتورة والملخص النهائي.

<img width="1793" height="779" alt="Screenshot 2026-06-26 065640" src="https://github.com/user-attachments/assets/d23f57d3-dbea-4c67-be7e-f7c23b5d0c49" />

* **ملخص وتأكيد الطلبات (صفحة فرعية تفتح بعد شاشة الإضافات):** شاشة مراجعة نهائية تقوم بحساب الإجمالي بدقة وتأمين الطلب لمنع التعديل العشوائي بعد التأكيد، مع ميزة إعادة تعيين الطلبات لبدء عملية جديدة فوراً بفتح قائمة الطعام من جديد.

<img width="1669" height="890" alt="Screenshot 2026-06-26 064151" src="https://github.com/user-attachments/assets/871ccdde-4d70-4915-a7af-38b7ebb4e6d3" />

<img width="1653" height="866" alt="Screenshot 2026-06-26 071328" src="https://github.com/user-attachments/assets/4e8c6204-5e98-4043-93ba-dc3e4029b5f0" />
---

## هيكلية الشاشات والملفات داخل النظام

بناءً على التصميم البرمجي للمشروع، ينقسم النظام إلى مجموعة من الواجهات المترابطة:

* **MainPage:** الشاشة الرئيسية وبوابة الدخول للنظام.
* **MenuePage:** شاشة القائمة واختيار الحجم ونوع العجينة وتحديد مكان تناول الطعام.
* **frmToppings:** شاشة التحكم في الإضافات وحساب الأسعار الإجمالية.
* **frmOrderSummary:** شاشة الفاتورة النهائية وتأكيد وتصفير الطلبات.
* **frmPriceList:** شاشة عرض قائمة الأسعار التفصيلية.
* **AboutUsPage:** شاشة التعريف بقصة المطعم ورسالته.

---

## التقنيات المستخدمة

* **لغة البرمجة:** سي شارب (#C)
* **بيئة التطوير:** مايكروسوفت فيجوال استوديو (Microsoft Visual Studio)
* **نوع التطبيق ونظام التشغيل:** واجهات مستخدم رسومية (Windows Forms App) مبني على دوت نت فريم وورك (.NET Framework)

---
🚀 تم تطوير هذا النظام كجزء من رحلة التطوير البرمجي وبناء الأنظمة الوظيفية المتقدمة!
