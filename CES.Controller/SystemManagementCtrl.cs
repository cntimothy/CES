using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CES.DataStructure;
using System.IO;

namespace CES.Controller
{
    public class SystemManagementCtrl
    {
        /// <summary>
        /// 获取所有被考评人信息，查询成功且不为空返回true，否则返回false
        /// </summary>
        /// <param name="table">包含被考评人信息的table（ID, Name, Sex, Job, Status（领导：已完成/总，中层干部：已完成/总，群众：已完成/总））</param>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool GetAll(ref DataTable table, ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 系统初始化，删除去年的信息（除考核表），设置成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool InitSystem(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 开始考评，设置成功返回true，否则返回false
        /// </summary>
        /// <param name="excpetion"></param>
        /// <returns></returns>
        public static bool StartEvaluation(ref string excpetion) 
        {
            return true;
        }

        /// <summary>
        /// 结束考评，设置成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool StopEvaluation(ref string exception)
        {
            return true;
        }

        /// <summary>
        /// 删除所有临时文件，成功返回true，否则返回false。（这个我来实现）
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ClearTempFiles(ref string exception)
        {
            DirectoryInfo folder = new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory.ToString() + @"downloadfiles\");
            FileInfo[] files = folder.GetFiles();
            try
            {
                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
            }
            catch (Exception e)
            {
                exception = e.Message;
                return false;
            }
            return true;
        }

        /// <summary>
        /// 清空所有数据，成功返回true，否则返回false
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static bool ClearDataBase(ref string exception)
        {
            return true;
        }
    }
}
