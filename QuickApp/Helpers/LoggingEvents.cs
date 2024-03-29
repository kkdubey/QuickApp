﻿// =============================
// Email: kkdubey1989@gmail.com
// https://github.com/kkdubey
// =============================

using Microsoft.Extensions.Logging;

namespace QuickApp.Helpers
{
    public static class LoggingEvents
    {
        public static readonly EventId INIT_DATABASE = new EventId(101, "Error whilst creating and seeding database");
        public static readonly EventId SEND_EMAIL = new EventId(201, "Error whilst sending email");
    }

}
