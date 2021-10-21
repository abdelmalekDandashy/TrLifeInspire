using System.Collections.Generic;
using Enyim.Caching;
using Enyim.Caching.Configuration;
using Enyim.Caching.Memcached;
using Microsoft.Extensions.Logging;
using System.Configuration;

namespace BLC
{
    public partial class BLC
    {
        public MemcachedClient Init_MemcachedClient()
        {
            #region Declaration And Initialization Section.
            #endregion
            #region Body Section.
            var serverList = new List<Server>
            {
              new Server
              {
                Address = ConfigurationManager.AppSettings["MEMCACHED_IP"],
                Port = System.Convert.ToInt32(ConfigurationManager.AppSettings["MEMCACHED_PORT"])
              }
            };

            // memcached client options
            var clientOptions = new MemcachedClientOptions { Servers = serverList , Protocol = MemcachedProtocol.Text };
            var logger = new LoggerFactory();
            var clientConfiguration = new MemcachedClientConfiguration(logger, clientOptions);

            // create memcached client
            MemcachedClient _MemcachedClient = new MemcachedClient(logger, clientConfiguration);
            #endregion

            #region Return Section.
            return _MemcachedClient;
            #endregion
        }

       
        public string Caching_Get_Entry(string key)
        {
            object toRet = null;
            try
            {
                if (this.My_MemcachedClient.TryGet(key, out toRet))
                {
                    return toRet.ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            catch (Exception ex)
            {
                Params_Log_Error oParams_Log_Error = new Params_Log_Error();
                oParams_Log_Error.MESSAGE = key + ":" + ex.ToString();
                Log_Error(oParams_Log_Error);
                return string.Empty;
            }
        }

        public void Caching_Set_Entry(string key, string value)
        {
            try
            {
                this.My_MemcachedClient.Store(StoreMode.Set, key, value);
                Archive_MemCache_Keys(key);
            }
            catch (Exception ex)
            {
                Params_Log_Error oParams_Log_Error = new Params_Log_Error();
                oParams_Log_Error.MESSAGE = key + ":" + ex.ToString();
                Log_Error(oParams_Log_Error);
            }
            
        }

        public void Caching_Flush_All()
        {
            this.My_MemcachedClient.FlushAll();
        }

        #region Archive_MemCache_Keys
        public string Archive_MemCache_Keys(string i_Key)
        {
            #region Declaration And Initialization Section.
            string content = string.Empty;
            #endregion
            #region Body Section.
            try
            {
                content = this.My_MemcachedClient.Get<String>("MY_KEYS");
                if (string.IsNullOrEmpty(content))
                {
                    this.My_MemcachedClient.Store(StoreMode.Set, "MY_KEYS", "");
                }
                content = string.Format("{0},{1}", content, i_Key);
                this.My_MemcachedClient.Store(StoreMode.Set, "MY_KEYS", content);
                return content;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
            #endregion
        }
        #endregion
    }
}
