
# Bank Queue Line Management System

This project represents a practical simulation system to manage bank and customer service queue lines dynamically. It falls under the category of **Functional Systems**, designed to issue temporal tracking tickets, monitor average service time delay matrices, and provide directional line visualization tools without losing or mutating the core linear memory layout.

This advanced educational system was developed under the supervision and guidance of the esteemed engineer: **Mohammed Abu-Hadhoud** via [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 System Overview

The system is a highly structured Class (`clsQueueLine`) built in C++ that orchestrates a real-world client dispatch sequence. It implements an internal nested helper class (`clsTicket`) to encapsulate the atomic attributes of individual tickets, such as sequence numbering, automated timestamps via `clsDate`, and customized alpha prefixes. The container layout protects the raw data workflow by using temporary snapshot buffers during processing to preserve original customer positions.

---

## 🛠️ System Features

The system offers an integrated suite of administrative control tools and customer interface modules:

### 1. Ticket Generation & Client Processing
* **Issue New Ticket:** Generates a dynamic sequential token with contextual prefix details and adds the client to the queue tail via the function `IssueTicket()`.
* **Serve Next Client:** Dispatches and dequeues the client currently standing at the front of the queue via the function `ServeNextClient()`.
* **State Lookups:** Checks active client status records via the properties `WhoIsNext()` and monitors active volume tracking via `WaitingClients()` and `ServedClients()`.

### 2. Directional Layout Visualization
* **Right-to-Left Tracking (RTL):** Renders the line flow matching FIFO data intake streams via the function `PrintTicketsLineRTL()`.
* **Left-to-Right Historical View (LTR):** Utilizes a temporary template adapter stack to completely invert the output stream sequence for alternative directional visualization via the function `PrintTicketsLineLTR()`.
* **Detailed Record Invoices:** Iterates through active data records and renders formatted individual ticket receipts via the function `PrintAllTickets()`.
* **Queue Diagnostics:** Displays immediate macro logs of total tickets, served counts, and active waiting lists via the function `PrintInfo()`.

---

## 💻 Code Architecture

Responsibilities within this **Functional System** demonstrate explicit object-oriented structural boundaries and encapsulation:

* **Nested Class Encapsulation (`clsTicket`):** Hidden strictly inside the outer layout, protecting ticket property accessors and calculations (like `ExpectedServeTime()`) since individual ticket structures have no logical purpose existing independently of the parent line manager.
* **Non-Destructive Container Traversal:** All printing and diagnostic mechanisms cleanly duplicate the core sequence (`QueueLine`) into short-lived template container objects (`TempQueueLine`), avoiding memory destruction during destructive evaluation patterns (`pop()`).

---

## 🎯 Engineering Deliverables

Developing this system ensures a deep understanding of several advanced programming concepts:
* **The Nested Class Pattern:** Architecting private or contextual localized inner classes to limit scope coupling inside larger frameworks.
* **Temporary State Replication:** Isolating live runtime containers by copying object states into throwaway template scopes to perform multi-directional iteration tracks.
* **Linear Time Matrices:** Coordinating multiple standard properties to construct real-time mathematical outputs like expected delay times.

---

## 🚀 Technologies Used

* **C++11 / C++17**
* **OOP Concepts (Nested Class Design, Structural Encapsulation)**
* **C++ Standard Template Library (`std::queue`, `std::stack`)**
* **Time and Date Core Extensions (`clsDate`)**

================================================================================

# نظام إدارة خطوط وطوابير الانتظار البنكية

هذا المشروع يمثل نظام محاكاة برمجية لتنظيم وإدارة طوابير الانتظار في البنوك ومراكز خدمة العملاء. وهو يندرج تحت تصنيف **Functional Systems**، حيث تم تصميمه لإصدار تذاكر تتبع زمنية، وحساب المصفوفات التقديرية لوقت الانتظار، مع توفير أدوات متطورة لعرض الخطوط اتجاهياً دون فقدان أو تدمير هيكلية البيانات الأصلية.

تم تطوير هذا النظام التعليمي المتقدم تحت إشراف وتوجيه المهندس القدير: **محمد أبو هدهود** عبر [Programming Advices](https://programmingadvices.com/courses/enrolled/2001432).

---

## 📌 عن النظام (System Overview)

النظام عبارة عن كلاس مخصص عالي التنسيق (`clsQueueLine`) تم بناؤه بلغة C++ لإدارة دورة حياة العملاء داخل الخدمة. يتضمن النظام كلاس داخلي مدمج ومغلف (`clsTicket`) لتمثيل تذكرة العميل الذاتية التي تسجل رقم العميل، والوقت التلقائي لإصدار التذكرة عبر كلاس التاريخ `clsDate` مع رمز تمييز مخصص (Prefix). يتميز النظام بحمايته لبيانات العملاء الفعلية عن طريق أخذ نسخ مؤقتة من طابور الذاكرة أثناء عمليات المعالجة والعرض لضمان عدم تأثر الخط الأصلي.

---

## 🛠️ المميزات والوظائف البرمجية (System Features)

يقدم النظام حزمة من الأدوات البرمجية لإدارة خط الانتظار واستخراج الإحصاءات الفورية كالتالي:

### 1. إصدار التذاكر ومعالجة العملاء
* **إصدار تذكرة جديدة:** توليد تذكرة متسلسلة فريدة وربطها برمز الطابور ثم إضافتها في نهاية خط الانتظار عبر الدالة `IssueTicket()`.
* **خدمة العميل التالي:** سحب وتمرير العميل الموجود في أول الخط وتحديث البيانات برمجياً عبر الدالة `ServeNextClient()`.
* **الاستعلام عن الحالات:** فحص هوية العميل التالي عبر الدالة `WhoIsNext()` ومراقبة الإحصاءات الرقمية للعملاء عبر الدالتين `WaitingClients()` و `ServedClients()`.

### 2. العرض الاتجاهي لخط الانتظار
* **الطباعة من اليمين إلى اليسار (RTL):** عرض تدفق الخط البرمجي بما يحاكي دخول البيانات الفعلي عبر الدالة `PrintTicketsLineRTL()`.
* **الطباعة العكسية من اليسار إلى اليمين (LTR):** استخدام حاوية مكدس مؤقتة لقلب ترتيب العرض بالكامل من أجل رؤية تاريخية مغايرة عبر الدالة `PrintTicketsLineLTR()`.
* **طباعة الفواتير التفصيلية:** استدعاء دالات العرض الداخلية لطباعة كافة تفاصيل التذاكر النشطة على شكل إيصالات مستقلة عبر الدالة `PrintAllTickets()`.
* **تقرير معلومات الطابور:** طباعة لوحة معلومات متكاملة تعرض الرمز، وإجمالي التذاكر، وعدد العملاء المنتظرين والمخدومين عبر الدالة `PrintInfo()`.

---

## 💻 هيكلية الكود البرمجي (Code Architecture)

تم تقسيم وتوزيع المسؤوليات داخل هذا الـ **Functional System** بالاعتماد على الفصل الهيكلي الدقيق لحماية البيانات:

* **تضمين الكلاسات الداخلية (`clsTicket`):** تم بناء كلاس التذكرة داخلياً (Nested Class) لتقييد النطاق البرمجي لها، حيث لا توجد حاجة هندسية لاستدعاء هيكل التذكرة خارج نطاق خط الانتظار المسؤول عنها، مع تزويدها بدوال حسابية ذاتية مثل وقت الخدمة المتوقع `ExpectedServeTime()`.
* **المعالجة غير المدمرة للحاويات:** تعتمد جميع دوال الطباعة والتشخيص على مبدأ النسخ الآمن لخط الانتظار الأساسي (`QueueLine`) إلى كائنات مؤقتة (`TempQueueLine`) لتجنب خسارة وتدمير البيانات أثناء استدعاء عملية الحذف المدمرة `pop()`.

---

## 🎯 الأهداف والمكتسبات الهندسية (Engineering Deliverables)

تطوير هذا النظام يضمن تحقيق فهم عميق لعدة مفاهيم برمجية متقدمة:
* **نمط الكلاسات المتداخلة (Nested Classes):** صياغة كلاسات محلية محجوبة لتقليل الاعتمادية والتشابك البرمجي داخل البنى البرمجية المعقدة.
* **النسخ المؤقت للحالات الحركية:** عزل الكائنات أثناء التشغيل عبر تدوير البيانات في حاويات STL مستقلة ومؤقتة لتنفيذ مسارات عرض متعددة الاتجاهات.
* **مصفوفات الوقت الخطية:** تنسيق دالات استعلام متعددة لربط حجم المنتظرين بمتوسط وقت الخدمة واستخراج مخرجات رياضية دقيقة لحظياً.

---

## 🚀 لغات وتقنيات مستخدمة

* **C++11 / C++17**
* **OOP Concepts (Nested Class Design, Structural Encapsulation)**
* **C++ Standard Template Library (`std::queue`, `std::stack`)**
* **Time and Date Core Extensions (`clsDate`)**
