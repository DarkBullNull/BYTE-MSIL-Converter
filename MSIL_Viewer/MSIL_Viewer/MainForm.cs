using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace MSIL_Viewer
{
    public partial class MainForm : Form
    {
        Dictionary<string, string> compareBytes = new Dictionary<string, string>()
            {
{	 "58", "add"            },
{    "D6", "add.ovf"        },
{    "D7", "add.ovf.un"     },
{    "5F", "and"            },
// {    "FE", "arglist"        },
{    "3B", "beq"            },
{    "2E", "beq.s"          },
{    "3C", "bge"            },
{    "2F", "bge.s"          },
{    "41", "bge.un"         },
{    "34", "bge.un.s"       },
{    "3D", "bgt"            },
{    "30", "bgt.s"          },
{    "42", "bgt.un"         },
{    "35", "bgt.un.s"       },
{    "3E", "ble"            },
{    "31", "ble.s"          },
{    "43", "ble.un"         },
{    "36", "ble.un.s"       },
{    "3F", "blt"            },
{    "32", "blt.s"          },
{    "44", "blt.un"         },
{    "37", "blt.un.s"       },
{    "40", "bne.un"         },
{    "33", "bne.un.s"       },
{    "8B", "box"            },
{    "38", "br"             },
{    "2B", "br.s"           },
{    "01", "break"          },
{    "39", "brfalse"        },
{    "2C", "brfalse.s"      },
// {    "3A", "brinst"         },
// {    "2D", "brinst.s"       },
// {    "39", "brnull"         },
// {    "2C", "brnull.s"       },
{    "3A", "brtrue"         },
{    "2D", "brtrue.s"       },
// {    "39", "brzero"         },
// {    "2C", "brzero.s"       },
{    "28", "call"           },
{    "6F", "callvirt"       },
{    "74", "castclass"      },
//{    "FE 01", "ceq"         },
//{    "FE 02", "cgt"         },
//{    "FE", "cgt.un"         },
{    "C3", "ckfinite"       },
// {    "FE", "clt"            },
//{    "FE", "clt.un"         },
//{    "FE", "constrained"    },
{    "D3", "conv.i"         },
{    "67", "conv.i1"        },
{    "68", "conv.i2"        },
{    "69", "conv.i4"        },
{    "6A", "conv.i8"        },
{    "D4", "conv.ovf.i"     },
{    "8A", "conv.ovf.i.un"  },
{    "B3", "conv.ovf.i1"    },
{    "82", "conv.ovf.i1.un" },
{    "B5", "conv.ovf.i2"    },
{    "83", "conv.ovf.i2.un" },
{    "B7", "conv.ovf.i4"    },
{    "84", "conv.ovf.i4.un" },
{    "B9", "conv.ovf.i8"    },
{    "85", "conv.ovf.i8.un" },
{    "D5", "conv.ovf.u"     },
// {    "8B", "conv.ovf.u.un"  },
{    "B4", "conv.ovf.u1"    },
{    "86", "conv.ovf.u1.un" },
{    "B6", "conv.ovf.u2"    },
{    "87", "conv.ovf.u2.un" },
{    "B8", "conv.ovf.u4"    },
{    "88", "conv.ovf.u4.un" },
{    "BA", "conv.ovf.u8"    },
{    "89", "conv.ovf.u8.un" },
{    "76", "conv.r.un"      },
{    "6B", "conv.r4"        },
{    "6C", "conv.r8"        },
{    "E0", "conv.u"         },
{    "D2", "conv.u1"        },
{    "D1", "conv.u2"        },
{    "6D", "conv.u4"        },
{    "6E", "conv.u8"        },
// {    "FE", "cpblk"          },
{    "70", "cpobj"          },
{    "5B", "div"            },
{    "5C", "div.un"         },
{    "25", "dup"            },
// {    "FE", "endfault"       },
// {    "FE", "endfilter"      },
{    "DC", "endfinally"     },
// {    "FE", "initblk"        },
// {    "FE", "initobj"        },
{    "75", "isinst"         },
{    "27", "jmp"            },
{    "FE", "ldarg"          },
{    "02", "ldarg.0"        },
{    "03", "ldarg.1"        },
{    "04", "ldarg.2"        },
{    "05", "ldarg.3"        },
{    "0E", "ldarg.s"        },
// {    "FE", "ldarga"         },
{    "0F", "ldarga.s"       },
{    "20", "ldc.i4"         },
{    "16", "ldc.i4.0"       },
{    "17", "ldc.i4.1"       },
{    "18", "ldc.i4.2"       },
{    "19", "ldc.i4.3"       },
{    "1A", "ldc.i4.4"       },
{    "1B", "ldc.i4.5"       },
{    "1C", "ldc.i4.6"       },
{    "1D", "ldc.i4.7"       },
{    "1E", "ldc.i4.8"       },
{    "15", "ldc.i4.m1"      },
// {    "15", "ldc.i4.M1"      },
{    "1F", "ldc.i4.s"       },
{    "21", "ldc.i8"         },
{    "22", "ldc.r4 "        },
{    "23", "ldc.r8"         },
{    "A3", "ldelem"         },
{    "97", "ldelem.i"       },
{    "90", "ldelem.i1"      },
{    "92", "ldelem.i2"      },
{    "94", "ldelem.i4"      },
{    "96", "ldelem.i8"      },
{    "98", "ldelem.r4"      },
{    "99", "ldelem.r8"      },
{    "9A", "ldelem.ref"     },
{    "91", "ldelem.u1"      },
{    "93", "ldelem.u2"      },
{    "95", "ldelem.u4"      },
// {    "96", "ldelem.u8"      },
{    "8F", "ldelema"        },
{    "7B", "ldfld"          },
{    "7C", "ldflda"         },
// {    "FE", "ldftn"          },
{    "4D", "ldind.i"        },
{    "46", "ldind.i1"       },
{    "48", "ldind.i2"       },
{    "4A", "ldind.i4"       },
{    "4C", "ldind.i8"       },
{    "4E", "ldind.r4"       },
{    "4F", "ldind.r8"       },
{    "50", "ldind.ref"      },
{    "47", "ldind.u1"       },
{    "49", "ldind.u2"       },
{    "4B", "ldind.u4"       },
// {    "4C", "ldind.u8"       },
{    "8E", "ldlen"          },
// {    "FE", "ldloc"          },
{    "06", "ldloc.0"        },
{    "07", "ldloc.1"        },
{    "08", "ldloc.2"        },
{    "09", "ldloc.3"        },
{    "11", "ldloc.s"        },
//{    "FE", "ldloca"         },
{    "12", "ldloca.s"       },
{    "14", "ldnull"         },
{    "71", "ldobj"          },
{    "7E", "ldsfld"         },
{    "7F", "ldsflda"        },
{    "72", "ldstr"          },
{    "D0", "ldtoken"        },
//{    "FE", "ldvirtftn"      },
{    "DD", "leave"          },
{    "DE", "leave.s"        },
//{    "FE", "localloc"       },
{    "C6", "mkrefany"       },
{    "5A", "mul"            },
{    "D8", "mul.ovf"        },
{    "D9", "mul.ovf.un"     },
{    "65", "neg"            },
{    "8D", "newarr"         },
{    "73", "newobj"         },
{    "??", "no"             },
{    "00", "nop"            },
{    "66", "not"            },
{    "60", "or"             },
{    "26", "pop"            },
// {    "FE", "readonly"       },
// {    "FE", "refanytype"     },
{    "C2", "refanyval"      },
{    "5D", "rem"            },
{    "5E", "rem.un"         },
{    "2A", "ret"            },
// {    "FE", "rethrow"        },
{    "62", "shl"            },
{    "63", "shr"            },
{    "64", "shr.un"         },
// {    "FE", "sizeof"         },
// {    "FE", "starg"          },
{    "10", "starg.s"        },
{    "A4", "stelem"         },
{    "9B", "stelem.i"       },
{    "9C", "stelem.i1"      },
{    "9D", "stelem.i2"      },
{    "9E", "stelem.i4"      },
{    "9F", "stelem.i8"      },
{    "A0", "stelem.r4"      },
{    "A1", "stelem.r8"      },
{    "A2", "stelem.ref"     },
{    "7D", "stfld"          },
{    "DF", "stind.i"        },
{    "52", "stind.i1"       },
{    "53", "stind.i2"       },
{    "54", "stind.i4"       },
{    "55", "stind.i8"       },
{    "56", "stind.r4"       },
{    "57", "stind.r8"       },
{    "51", "stind.ref"      },
// {    "FE", "stloc"          },
{    "0A", "stloc.0"        },
{    "0B", "stloc.1"        },
{    "0C", "stloc.2"        },
{    "0D", "stloc.3"        },
{    "13", "stloc.s"        },
{    "81", "stobj"          },
{    "80", "stsfld"         },
{    "59", "sub"            },
{    "DA", "sub.ovf"        },
{    "DB", "sub.ovf.un"     },
{    "45", "switch"         },
// {    "FE", "tail"           },
{    "7A", "throw"          },
// {    "FE", "unaligned"      },
{    "79", "unbox"          },
{    "A5", "unbox.any"      },
// {    "FE", "volatile"       },
{    "61", "xor"			}
            };
        public MainForm()
        {
            InitializeComponent();
        }
        
        
        static List<string> SplitString(string str)
        {
            List<string> list = new List<string>();
            int i = 0;
            while (i < str.Length - 1)
            {
                list.Add(str.Substring(i, 2));
                i += 2;
            }
            return list;
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            resultBox.Items.Clear();
            string preparedText = startTextBox.Text.Replace('\n', ' ').Replace(" ", "").ToUpper();
            List<string> arrayBytes = SplitString(preparedText);
            foreach (var strbyte in arrayBytes)
            {
                string outMSIL;
                compareBytes.TryGetValue(strbyte, out outMSIL);
                if (outMSIL == null)
                {
                    resultBox.Items.Add($"OpCode 0x{strbyte.ToUpper()} not found");
                }
                else
                {
                    resultBox.Items.Add(outMSIL);
                }
                
            }
        }
    }
}