//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Eed : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Eed(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Eed obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Eed() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          LibreDWGPINVOKE.delete_Dwg_Eed(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ushort size {
    set {
      LibreDWGPINVOKE.Dwg_Eed_size_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.Dwg_Eed_size_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_Handle handle {
    set {
      LibreDWGPINVOKE.Dwg_Eed_handle_set(swigCPtr, Dwg_Handle.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Eed_handle_get(swigCPtr);
      Dwg_Handle ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Handle(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Eed_Data data {
    set {
      LibreDWGPINVOKE.Dwg_Eed_data_set(swigCPtr, Dwg_Eed_Data.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Eed_data_get(swigCPtr);
      Dwg_Eed_Data ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Eed_Data(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char raw {
    set {
      LibreDWGPINVOKE.Dwg_Eed_raw_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Eed_raw_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Eed() : this(LibreDWGPINVOKE.new_Dwg_Eed(), true) {
  }

}
