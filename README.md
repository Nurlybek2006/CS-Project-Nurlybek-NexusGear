# NEXUS GEAR

**Beyond ordinary hardware.** Premium technology catalog and interactive PC configuration experience built with ASP.NET Core MVC and Razor. Interface language: Kazakh. Currency: KZT.

**Автор:** Nurlybek Sarsenbekuly · ИСК-242 · **GitHub:** [Nurlybek2006](https://github.com/Nurlybek2006)

## Жоба туралы

Nexus Gear — Week 2 ProductCatalog тапсырмасының талаптарын орындайтын және портфолиоға арналған интерфейспен кеңейтілген ASP.NET Core MVC қолданбасы. Каталог деректері сервис ішінде жадта сақталады; дерекқор мен жалған сатып алу ағыны жоқ.

## Стек және құрылым

- .NET 10, ASP.NET Core MVC, dependency injection
- C#, Razor Views, strongly typed ViewModels
- Bootstrap 5 (жобаға қосылған пакет), Vanilla JavaScript, CSS custom properties
- `Controllers/` — Home, Catalog, Product, PcBuilder, Compare, Favorites бағыттары
- `Models/` — өнім моделі және каталог деректері
- `Services/` — каталог интерфейсі мен seed деректері
- `ViewModels/` — беттерге арналған типтелген модельдер
- `Views/` — MVC беттері және ортақ Razor partial
- `wwwroot/css`, `wwwroot/js`, `wwwroot/images` — стиль, әрекеттер және жергілікті SVG визуалдары

## Университет тапсырмасы

| Талап | Іске асырылуы |
|---|---|
| Product моделі | `Models/Product.cs` ішінде Id, Name, Price, Category, IsAvailable және қосымша бренд/сипаттама өрістері бар. |
| Strongly Typed Views | Басты бет, каталог, өнім мәліметі, PC Builder және салыстыру беттері нақты ViewModel-дерді пайдаланады. |
| ViewData | Контроллерлер `ViewData["Title"]` арқылы бет тақырыбын layout-қа береді. |
| ViewBag | Home және Catalog контроллерлері `ViewBag.TotalProducts` арқылы өнім санын береді. |
| Layout және RenderBody | `Views/Shared/_Layout.cshtml` ортақ навигация, Bootstrap, CSS/JS және `@RenderBody()` қамтиды. |
| Partial View | `_ProductCard.cshtml` басты бетте, каталогта және таңдаулылар бетінде қайта қолданылады; Quick View бөлек partial ретінде серверден жүктеледі. |
| Razor өрнектері/шарттар | Өнім карточкасы баға, белгі және қойма күйін Razor өрнек/шарттарымен көрсетеді. |
| Bootstrap 5 | Локалдық Bootstrap CSS/JS файлдары layout-та қосылған; визуалдың негізгі стилі жеке CSS-пен берілген. |
| GitHub құрылымы | MVC контроллерлері, модельдер, ViewModels, сервис, Views, статик файлдар және осы README жобада бар. |

## Негізгі мүмкіндіктер

- 52 demo өнім және KZT бағалары бар ізделетін, санатпен сүзілетін/реттелетін каталог.
- Өнімнің толық беті және Quick View modal.
- Таңдаулылар мен үш өнімге дейін салыстыру тізімдері браузердің localStorage қоймасында сақталады.
- PC Builder: 8 компонент санаты, берілген сокет/RAM/form factor/GPU және салқындатқыш деректері бойынша үйлесімділік тексеруі, баға жиыны.
- Қуат бағасы CPU/GPU көрсетілген жағдайда (CPU + GPU + 150 W) × 1.30 қағидасымен есептеледі. Қажетті дерек жоқ кезде белгісіздік көрсетіледі.
- PC конфигурациясын `nexus-gear:pc-builder:v1` кілтімен сақтау және нақты JSON файлы ретінде экспорттау.
- Dark/light тақырып, mobile navigation, `prefers-reduced-motion` ескеріледі.

### Razor ұғымдары

- **Model:** Product класы бес негізгі міндетті өрісті сақтайды; қосымша сипаттамалары UI-да қолданылады.
- **ViewModel:** әр бет контроллерден қажет деректі жинақталған типпен алады.
- **ViewData:** беттің жеке атауын layout-та көрсетуге береді.
- **ViewBag:** өнімдердің динамикалық санын көрсету үшін қолданылады.
- **Layout:** ортақ header/footer және `@RenderBody()` көмегімен бет мазмұнын орналастырады.
- **Partial:** `_ProductCard` өнім бейнесі, баға және клиенттік әрекеттерді қайталамай көрсетеді.
- **Razor шарттары:** қолжетімділік пен жаңа өнім белгісі модельге қарай өзгереді.

### PC Builder үйлесімділігі

Құрылымдық спецификация seed деректеріндегі тек көрсетілген мәндерден шығарылады. CPU сокеті мен плата сокеті, RAM және платаның жад түрі, плата/корпус өлшемі, GPU ұзындығы мен корпус шегі, CPU сокеті және салқындатқыш қолдауы салыстырылады. Дерек жоқ болса интерфейс тексерудің толық еместігін айтады; белгісіз үйлесімділікті жасыл растамайды. PSU ұсынысына 30% қауіпсіз қор қосылады.

## Іске қосу

```powershell
dotnet restore
dotnet build
dotnet run
```

`Properties/launchSettings.json` берген жергілікті URL мекенжайын ашыңыз. Сыртқы Google Fonts қолжетімсіз болса жүйелік sans-serif fallback қолданылады; барлық өнім иллюстрациялары жергілікті SVG.

## Тексеру

```powershell
dotnet build
```

Қолмен тексеру: басты беттен каталог/санатқа өту, іздеу мен сорттау, өнім мәліметтері, Quick View, таңдаулы және салыстыру батырмалары, тақырып ауыстыру, PC Builder таңдау/үйлесімділік/экспорт, браузер терезесін mobile енге тарылту.

## Скриншоттар

Скриншоттар әзірге түсірілген жоқ.
