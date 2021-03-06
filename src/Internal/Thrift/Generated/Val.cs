/**
 * Autogenerated by Thrift Compiler (@PACKAGE_VERSION@)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Thrift;
using Thrift.Collections;

using Thrift.Protocols;
using Thrift.Protocols.Entities;
using Thrift.Protocols.Utilities;
using Thrift.Transports;
using Thrift.Transports.Client;
using Thrift.Transports.Server;



public partial class Val : TBase
{
  private long _bigint;
  private int _integer;
  private short _smallint;
  private double _real;
  private bool _bval;
  private string _text;
  private bool _isnull;
  private byte[] _blob;

  public long Bigint
  {
    get
    {
      return _bigint;
    }
    set
    {
      __isset.bigint = true;
      this._bigint = value;
    }
  }

  public int Integer
  {
    get
    {
      return _integer;
    }
    set
    {
      __isset.integer = true;
      this._integer = value;
    }
  }

  public short Smallint
  {
    get
    {
      return _smallint;
    }
    set
    {
      __isset.smallint = true;
      this._smallint = value;
    }
  }

  public double Real
  {
    get
    {
      return _real;
    }
    set
    {
      __isset.real = true;
      this._real = value;
    }
  }

  public bool Bval
  {
    get
    {
      return _bval;
    }
    set
    {
      __isset.bval = true;
      this._bval = value;
    }
  }

  public string Text
  {
    get
    {
      return _text;
    }
    set
    {
      __isset.text = true;
      this._text = value;
    }
  }

  public bool Isnull
  {
    get
    {
      return _isnull;
    }
    set
    {
      __isset.isnull = true;
      this._isnull = value;
    }
  }

  public byte[] Blob
  {
    get
    {
      return _blob;
    }
    set
    {
      __isset.blob = true;
      this._blob = value;
    }
  }


  public Isset __isset;
  public struct Isset
  {
    public bool bigint;
    public bool integer;
    public bool smallint;
    public bool real;
    public bool bval;
    public bool text;
    public bool isnull;
    public bool blob;
  }

  public Val()
  {
  }

  public async Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      TField field;
      await iprot.ReadStructBeginAsync(cancellationToken);
      while (true)
      {
        field = await iprot.ReadFieldBeginAsync(cancellationToken);
        if (field.Type == TType.Stop)
        {
          break;
        }

        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I64)
            {
              Bigint = await iprot.ReadI64Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 2:
            if (field.Type == TType.I32)
            {
              Integer = await iprot.ReadI32Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 3:
            if (field.Type == TType.I16)
            {
              Smallint = await iprot.ReadI16Async(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 4:
            if (field.Type == TType.Double)
            {
              Real = await iprot.ReadDoubleAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 5:
            if (field.Type == TType.Bool)
            {
              Bval = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 6:
            if (field.Type == TType.String)
            {
              Text = await iprot.ReadStringAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 7:
            if (field.Type == TType.Bool)
            {
              Isnull = await iprot.ReadBoolAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          case 8:
            if (field.Type == TType.String)
            {
              Blob = await iprot.ReadBinaryAsync(cancellationToken);
            }
            else
            {
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            }
            break;
          default: 
            await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
            break;
        }

        await iprot.ReadFieldEndAsync(cancellationToken);
      }

      await iprot.ReadStructEndAsync(cancellationToken);
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public async Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
  {
    oprot.IncrementRecursionDepth();
    try
    {
      var struc = new TStruct("Val");
      await oprot.WriteStructBeginAsync(struc, cancellationToken);
      var field = new TField();
      if (__isset.bigint)
      {
        field.Name = "bigint";
        field.Type = TType.I64;
        field.ID = 1;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI64Async(Bigint, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.integer)
      {
        field.Name = "integer";
        field.Type = TType.I32;
        field.ID = 2;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI32Async(Integer, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.smallint)
      {
        field.Name = "smallint";
        field.Type = TType.I16;
        field.ID = 3;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteI16Async(Smallint, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.real)
      {
        field.Name = "real";
        field.Type = TType.Double;
        field.ID = 4;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteDoubleAsync(Real, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.bval)
      {
        field.Name = "bval";
        field.Type = TType.Bool;
        field.ID = 5;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBoolAsync(Bval, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Text != null && __isset.text)
      {
        field.Name = "text";
        field.Type = TType.String;
        field.ID = 6;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteStringAsync(Text, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (__isset.isnull)
      {
        field.Name = "isnull";
        field.Type = TType.Bool;
        field.ID = 7;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBoolAsync(Isnull, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      if (Blob != null && __isset.blob)
      {
        field.Name = "blob";
        field.Type = TType.String;
        field.ID = 8;
        await oprot.WriteFieldBeginAsync(field, cancellationToken);
        await oprot.WriteBinaryAsync(Blob, cancellationToken);
        await oprot.WriteFieldEndAsync(cancellationToken);
      }
      await oprot.WriteFieldStopAsync(cancellationToken);
      await oprot.WriteStructEndAsync(cancellationToken);
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override string ToString()
  {
    var sb = new StringBuilder("Val(");
    bool __first = true;
    if (__isset.bigint)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Bigint: ");
      sb.Append(Bigint);
    }
    if (__isset.integer)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Integer: ");
      sb.Append(Integer);
    }
    if (__isset.smallint)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Smallint: ");
      sb.Append(Smallint);
    }
    if (__isset.real)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Real: ");
      sb.Append(Real);
    }
    if (__isset.bval)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Bval: ");
      sb.Append(Bval);
    }
    if (Text != null && __isset.text)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Text: ");
      sb.Append(Text);
    }
    if (__isset.isnull)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Isnull: ");
      sb.Append(Isnull);
    }
    if (Blob != null && __isset.blob)
    {
      if(!__first) { sb.Append(", "); }
      __first = false;
      sb.Append("Blob: ");
      sb.Append(Blob);
    }
    sb.Append(")");
    return sb.ToString();
  }
}

