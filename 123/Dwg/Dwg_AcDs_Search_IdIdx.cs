//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_AcDs_Search_IdIdx : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_AcDs_Search_IdIdx(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_AcDs_Search_IdIdx obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_AcDs_Search_IdIdx() {
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
          LibreDWGPINVOKE.delete_Dwg_AcDs_Search_IdIdx(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ulong handle {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_IdIdx_handle_set(swigCPtr, value);
    } 
    get {
      ulong ret = LibreDWGPINVOKE.Dwg_AcDs_Search_IdIdx_handle_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_ididx {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_IdIdx_num_ididx_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_Search_IdIdx_num_ididx_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_long_long ididx {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_Search_IdIdx_ididx_set(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AcDs_Search_IdIdx_ididx_get(swigCPtr);
      SWIGTYPE_p_unsigned_long_long ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_long_long(cPtr, false);
      return ret;
    } 
  }

  public Dwg_AcDs_Search_IdIdx() : this(LibreDWGPINVOKE.new_Dwg_AcDs_Search_IdIdx(), true) {
  }

}