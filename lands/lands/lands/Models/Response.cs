﻿

namespace lands.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    //Servicio para consumir APIS
    class Response
    {
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public object Result
        {
            get;
            set;
        }
    }
}
