//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class eed_data_t_eed_0_r2007 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal eed_data_t_eed_0_r2007(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(eed_data_t_eed_0_r2007 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~eed_data_t_eed_0_r2007() {
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
          LibreDWGPINVOKE.delete_eed_data_t_eed_0_r2007(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ushort length {
    set {
      LibreDWGPINVOKE.eed_data_t_eed_0_r2007_length_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE.eed_data_t_eed_0_r2007_length_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_short string_ {
    set {
      LibreDWGPINVOKE.eed_data_t_eed_0_r2007_string__set(swigCPtr, SWIGTYPE_p_unsigned_short.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.eed_data_t_eed_0_r2007_string__get(swigCPtr);
      SWIGTYPE_p_unsigned_short ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_short(cPtr, false);
      return ret;
    } 
  }

  public eed_data_t_eed_0_r2007() : this(LibreDWGPINVOKE.new_eed_data_t_eed_0_r2007(), true) {
  }

}
