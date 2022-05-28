﻿namespace DNSLab.Prividers
{
    public class MetadataProvider
    {
        public Dictionary<string, MetadataValue> RouteDetailMapping { get; set; } = new()
        {
            {
                "/",
                new()
                {
                    Title = "دی‌ان‌اس لب - DNSLab",
                    Description = "داینامیک دی ان اس رایگان",
                    Keywords = new string[] { "دی ان اس رایگان", "home", "خانه" }
                }
            },
            {
                "/user/auth",
                new()
                {
                    Title = "ورود به سیستم",
                    Description = "ورود به حساب کاربری سایت دی‌ان‌اس لب",
                    Keywords = new string[] { "ورود به حساب کاربری", "ورود به سیستم" }
                }
            },
            {
                "/user/register",
                new()
                {
                    Title = "ثبت نام در سیستم",
                    Description = "ثبت نام در سایت دی‌ان‌اس لب",
                    Keywords = new string[] { "ثبت نام", "ایجاد حساب کاربری" }
                }
            },
            {
                "/api",
                new()
                {
                    Title = "API های سایت",
                    Description = "API - برای توسعه دهندگان",
                    Keywords = new string[] { "API", "ای‌پی‌آی", "IP" }
                }
            },
            {
                "/Comment/Create",
                new()
                {
                    Title = "ارسال دیدگاه",
                    Description = "ارسال دیدگاه برای سایت dnslab",
                    Keywords = new string[] { "ایجاد دیدگاه", "create new comment" }
                }
            },
            {
                "/Comment/Edit/{CommentId:guid}",
                new()
                {
                    Title = "ویرایش دیدگاه ارسال شده",
                    Description = "ویرایش دیدگاه ارسال شده به سایت dnslab",
                    Keywords = new string[] { "ویرایش دیدگاه", "edit comment" }
                }
            },
            {
                "/Comment/MyComments",
                new()
                {
                    Title = "دیدگاه‌های من",
                    Description = "دیدگاه‌های من",
                    Keywords = new string[] { "دیدگاه های من", "my comments" }
                }
            },
            {
                "/legal/tos",
                new()
                {
                    Title = "قوانین و شرایط استفاده",
                    Description = "قوانین و شرایط استفاده از سایت dnslab",
                    Keywords = new string[] { "شرایط و ضوابط", "term of service" }
                }
            },
            {
                "/dns/create",
                new()
                {
                    Title = "ایجاد هاست‌نیم جدید",
                    Description = "صفحه ایجاد هاست‌نیم یا دی‌ان‌اس جدید",
                    Keywords = new string[] { "ایجاد دی ان اس", "create dns" }
                }
            },
            {
                "/dns/createtoken",
                new()
                {
                    Title = "ایجاد توکن جدید",
                    Description = "صفحه ایحاد توکن جدید",
                    Keywords = new string[] { "ایجاد توکن", "create token" }
                }
            },
            {
                "/DNS/Histories",
                new()
                {
                    Title = "تاریخچه تغییرات",
                    Description = "تاریخچه تغییرات آی‌پی و هاست‌نیم های شما",
                    Keywords = new string[] { "تاریخچه تغییرات", "changes histories" }
                }
            },
            {
                "/dns/edit/{HostNameId:guid}",
                new()
                {
                    Title = "ویرایش هاست‌نیم",
                    Description = "ویرایش هاست‌نیم ایجاد شده",
                    Keywords = new string[] { "ویرایش دی ان اس", "edit dns" }
                }
            },
            {
                "/dns/token/edit/{TokenId:guid}",
                new()
                {
                    Title = "ویرایش توکن",
                    Description = "ویرایش توکن ایجاد شده",
                    Keywords = new string[] { "ویرایش توکن", "edit token" }
                }
            },
            {
                "/dns/mydns",
                new()
                {
                    Title = "هاست‌نیم ها",
                    Description = "دی‌ان‌اس یا هاست نیم های من",
                    Keywords = new string[] { "دی ان اس های من", "my DNSs" }
                }
            },
            {
                "/dns/mytokens",
                new()
                {
                    Title = "توکن ها",
                    Description = "توکن های ثبت شما من",
                    Keywords = new string[] { "توکن های من", "my tokens" }
                }
            },
            {
                "/download/win",
                new()
                {
                    Title = "صفحه دانلود",
                    Description = "دانلود برنامه های DNSLab",
                    Keywords = new string[] { "دالنود" , "برنامه ویندوزی", "download win" }
                }
            },
            {
                "/404",
                new()
                {
                    Title = "صفحه مورد نظر یافت نشد",
                    Description = "صفحه مورد نظر یافت نشد",
                    Keywords = new string[] { "404", "not found" , "صفحه یافت نشد" }
                }
            },
            {
                "/500",
                new()
                {
                    Title = "خطای داخلی سرور رخ داده",
                    Description = "خطای داخلی سرور رخ داده",
                    Keywords = new string[] { "500" , "خطای داخلی سرور" , "internal server error" }
                }
            },
            {
                "/503",
                new()
                {
                    Title = "سرویس در دسترس نیست",
                    Description = "سرویس در دسترس نیست",
                    Keywords = new string[] { "503" , "سرویس در دسترس نیست", "Service is unavailable" }
                }
            },
            {
                "/Support",
                new()
                {
                    Title = "پشتیبانی",
                    Description = "صفحه پشتیبانی و راهنمای سایت DNSLab",
                    Keywords = new string[] { "پشتیبانی", "support" }
                }
            },
            {
                "/tools/dnslookup",
                new()
                {
                    Title = "جستجوی دی‌ان‌اس",
                    Description = "جستجو و دریافت آی‌پی بر اساس دی‌ان‌اس",
                    Keywords = new string[] { "جستجوی دی ان اس", "dns lookup" }
                }
            },
            {
                "/tools/ping",
                new()
                {
                    Title = "پینگ",
                    Description = "بررسی پینگ بر اساس آی‌پی یا ‌آدرس",
                    Keywords = new string[] { "بررسی پینگ", "ping" }
                }
            },
            {
                "/tools/port",
                new()
                {
                    Title = "بررسی پورت",
                    Description = "بررسی باز بودن پورت آی‌پی یا آدرس",
                    Keywords = new string[] { "بررسی باز بودن پورت", "port checker" }
                }
            },
            {
                "/tools/reverselookup",
                new()
                {
                    Title = "جستجوی معکوس",
                    Description = "جستجو بر اساس آی‌پی و بدست آوردن آدرس DNS (دی‌ان‌اس)",
                    Keywords = new string[] { "جستجوی معکوس ای پی یا آدرس", "reverse lookup" }
                }
            },
            {
                "/tools",
                new()
                {
                    Title = "ابزار",
                    Description = "ابزار های سایت DNSLab",
                    Keywords = new string[] { "ابزار ها", "tools" }
                }
            },
            {
                "/user/ChangePassword",
                new()
                {
                    Title = "تغییر رمز عبور",
                    Description = "تغییر رمز عبور در سایت",
                    Keywords = new string[] { "تغییر رمز عبور", "change password" }
                }
            },
            {
                "/User/ConfirmEmail/{Token}",
                new()
                {
                    Title = "تایید ایمیل",
                    Description = "تایید ایمیل حساب کاربری در سایت dnslab",
                    Keywords = new string[] { "تایید ایمیل", "confirm email" }
                }
            },
            {
                "/user/ForgetPassword",
                new()
                {
                    Title = "فراموشی رمز عبور",
                    Description = "فراموشی رمز عبور ، رمز عبور خود را فراموش کرده ام",
                    Keywords = new string[] { "فراموشی رمز عبور", "forget password" }
                }
            },
            {
                "/user/info",
                new()
                {
                    Title = "اطلاعات حساب کاربری",
                    Description = "اطلاعات حساب کاربری و اطلاعات ورود و نام کاربری و ...",
                    Keywords = new string[] { "اطلاعات حساب کاربری", "user information" }
                }
            },
            {
                "/user/logout",
                new()
                {
                    Title = "خروج",
                    Description = "خروج",
                    Keywords = new string[] { "خروج", "logout" }
                }
            },
            {
                "/user/ResetPassword/{Token}",
                new()
                {
                    Title = "بازیابی رمز عبور",
                    Description = "بازیابی رمز عبور و انتخاب رمز جدید",
                    Keywords = new string[] { "بازیابی رمز عبور", "reset password" }
                }
            }
        };
    }

    public class MetadataValue
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Keywords { get; set; }
    }
}