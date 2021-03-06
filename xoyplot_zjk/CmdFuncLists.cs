﻿using lk_protecl;
using lk_verify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZSeial;

namespace xoyplot_zjk
{
    class CmdFuncLists
    {

        #region  测量
        /// <summary>
        /// 停止测量
        /// </summary>
        public void dist_stop()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_dist_ctl);
            frame.id = (byte)(Protecl_typical_cmd.dist_ctl_id.dist_stop);
            frame.ifHeadOnly = true;
            frame.sendFrame( frame);
        }

        /// <summary>
        /// 连续测量
        /// </summary>
        public void dist_continue()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_dist_ctl);
            frame.id = (byte)(Protecl_typical_cmd.dist_ctl_id.dist_continue);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }    
        /// <summary>
        /// 单次测量
        /// </summary>
        public void dist_once()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_dist_ctl);
            frame.id = (byte)(Protecl_typical_cmd.dist_ctl_id.dist_once);
            frame.ifHeadOnly = true;
            frame.sendFrame( frame);
        }
        /// <summary>
        /// 调试模式测量
        /// </summary>
        public void sensor_debugMode_switch()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_ack_id.sensor_debugMode_switch);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 标定模式
        /// </summary>
        public void sensor_qcStandMode_switch()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_ack_id.sensor_dist_standMode_switch);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 正常模式
        /// </summary>
        public void sensor_mormalMode_switch()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_ack_id.sensor_normalMode_switch);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }
        #endregion

        #region 配置
        /// <summary>
        /// 红外辅助光配置
        /// </summary>
        /// <param name="buf">1灯亮，0灯灭</param>
        public void sensor_redLight(byte []buf)
        {
            //tinyFrame frame = new tinyFrame();
            //frame.Type = (byte)(Protecl_typical_cmd.ctl_type.);
            //frame.ifHeadOnly = false;  //含有数据帧
            //frame.id = (byte)(Protecl_typical_cmd.saveParm_id.saveRedLight);  
            //frame.dataBuf = buf;    //数据帧缓存
            //frame.len = (UInt16)buf.Length; //数据帧字节长度
            //frame.sendFrame(lk_serial, frame);
        }
        /// <summary>
        /// 自动测量命令
        /// </summary>
        /// <param name="buf">1打开自动测量；0关闭</param>
        public void sensor_autoMel(byte[] buf)
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_paramCfg_set);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.paramCfg_set_id.powerOn_mode);  
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }
       
        /// <summary>
        /// 波特率设置
        /// </summary>
        /// <param name="buf">0->9600;1->14400;2->19200;3->38400;4->57600;5->115200 </param>
        ///
        public void sensor_baudRate(byte[] buf)
        {
             tinyFrame frame = new tinyFrame();
           int text= frame.get_test();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_paramCfg_set);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.paramCfg_set_id.baudRate);
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }

        /// <summary>
        /// 输出频率设置
        /// </summary>
        /// <param name="buf"> 高字节在前</param>
        public void sensor_outdata_freq(byte[] buf)
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_paramCfg_set);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.paramCfg_set_id.outData_freq);
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 前后基准配置
        /// </summary>
        /// <param name="buf">1前基准，0后基准</param>
        public void sensor_front_base(byte[] buf)
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_paramCfg_set);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.paramCfg_set_id.disBase);
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 复位，恢复出厂设置
        /// </summary>
        public void sensor_reset()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.system_boot_param);
            frame.id = (byte)(Protecl_typical_cmd.usr_boot_ctl_id.usr_reset);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }

        /// <summary>
        /// 获取传感器参数
        /// </summary>
        public void sensor_get_param()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.usr_paramCfg_get);
            frame.id = (byte)(Protecl_typical_cmd.paramCfg_get_id.lk_all);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }

        /// <summary>
        /// 开关量上限
        /// </summary>
        /// <param name="buf"></param>
        public void sensor_set_switch_front(byte[] buf)
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_paramCfg_set);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.paramCfg_set_id.frontSwich);
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }

        /// <summary>
        /// 开关量下限
        /// </summary>
        /// <param name="buf"></param>
        public void sensor_set_switch_base(byte[] buf)
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.user_paramCfg_set);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.paramCfg_set_id.backSwich);
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 恢复出厂设置
        /// </summary>
        public void sensor_reset_param()
        {
          
        }
        #endregion


        #region  QC 标定
        /// <summary>
        /// 第一档切换
        /// </summary>
        /// <param name="buf"></param>
        public void qc_first_switch()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standFirst_switch);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);

        }
        /// <summary>
        /// 第2档切换
        /// </summary>
        /// <param name="buf"></param>
        public void qc_second_switch()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standSecond_switch);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);

        }
        /// <summary>
        /// 第三档切换
        /// </summary>
        /// <param name="buf"></param>
        public void qc_third_switch()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standthird_switch);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);

        }
        /// <summary>
        /// 获取标定参数
        /// </summary>
        public void qc_get_param()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_get_param);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }

        /// <summary>
        /// 保存第一档标定参数
        /// </summary>
        /// <param name="buf">数据</param>
        public void qc_save_first_param(byte[] buf)
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standFirst_save);  //校准参数
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 保存第2档标定参数
        /// </summary>
        /// <param name="buf">数据</param>
        public void qc_save_second_param(byte[] buf)
        {
            //发送保存参数
            //发送消息 前基准
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standSecond_save);  //校准参数
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 保存第3档标定参数
        /// </summary>
        /// <param name="buf">数据</param>
        public void qc_save_third_param(byte[] buf)
        {
            //发送保存参数
            //发送消息 前基准
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.ifHeadOnly = false;  //含有数据帧
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standthird_save);  //校准参数
            frame.dataBuf = buf;    //数据帧缓存
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }

        /// <summary>
        /// 复位第一档
        /// </summary>
        public void qc_reset_first_parm()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standFirst_reset);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 复位第2档
        /// </summary>
        public void qc_reset_second_parm()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standSecond_reset);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 复位第3档
        /// </summary>
        public void qc_reset_third_parm()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.programer_ctl);
            frame.id = (byte)(Protecl_typical_cmd.programer_id.qc_standthird_reset);
            frame.ifHeadOnly = true;
            frame.sendFrame(frame);
        }
        #endregion


        #region 固件升级
        /// <summary>
        /// 固件升级命令
        /// </summary>
        public void lk_download_start()
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.system_boot_firmware_ctl);
            frame.id = (byte)(Protecl_typical_cmd.firmware_ctl_id.firmware_begin);
            frame.ifHeadOnly = true;  //含有数据帧
            frame.sendFrame(frame);
        }
        /// <summary>
        /// 应答
        /// </summary>
        public void lk_download_ack()
        {
            //tinyFrame frame = new tinyFrame();
            //frame.Type = (byte)(Protecl_typical_cmd.ctl_type.system_boot_firmware_ctl);
            //frame.id = (byte)(Protecl_typical_cmd.download_id.start);
            //frame.ifHeadOnly = true;  //不含数据帧
            //frame.sendFrame(lk_serial, frame);
        }
        /// <summary>
        /// 包发送命令
        /// </summary>
        /// <param name="buf">数据</param>
        /// <param name="packge_cnt">发送包id</param>
        public void lk_firmware_send(byte[] buf,byte packge_cnt)
        {
            tinyFrame frame = new tinyFrame();
            frame.Type = (byte)(Protecl_typical_cmd.ctl_type.system_boot_firmware_pakage);
            frame.id = packge_cnt;
            frame.ifHeadOnly = false;  //含有数据帧
            frame.dataBuf = buf;
            frame.len = (UInt16)buf.Length; //数据帧字节长度
            frame.sendFrame(frame);
        }
        enum Package_enum_ { firstPackage = 1, dataPackaged };
        Package_enum_ package_statu = Package_enum_.firstPackage;
        /// <summary>
        /// firmawre download 应答回调函数
        /// </summary>
        /// <param name="ackID"></param>
        public void lk_firmware_Callback(Protecl_typical_cmd.ctl_type ackID)
        {
            //Protecl_typical_cmd.ack_id _ack = ackID;
            //switch (_ack)
            //{
            //    case Protecl_typical_cmd.ack_id.lk_download_ack:
            //        {
            //            switch (package_statu)
            //            {
            //                case Package_enum_.firstPackage:
            //                    {

            //                    }
            //                    break;
            //                case Package_enum_.dataPackaged:
            //                    {

            //                    }
            //                    break;
            //            }
            //        }
            //        break;
            //}
        }
            #endregion


        }
}
