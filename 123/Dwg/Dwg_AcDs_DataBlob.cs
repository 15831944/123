//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_AcDs_DataBlob : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_AcDs_DataBlob(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_AcDs_DataBlob obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_AcDs_DataBlob() {
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
          LibreDWGPINVOKE.delete_Dwg_AcDs_DataBlob(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ulong data_size {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_DataBlob_data_size_set(swigCPtr, value);
    } 
    get {
      ulong ret = LibreDWGPINVOKE.Dwg_AcDs_DataBlob_data_size_get(swigCPtr);
      return ret;
    } 
  }

  public uint page_count {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_DataBlob_page_count_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_DataBlob_page_count_get(swigCPtr);
      return ret;
    } 
  }

  public uint record_size {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_DataBlob_record_size_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_DataBlob_record_size_get(swigCPtr);
      return ret;
    } 
  }

  public uint page_size {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_DataBlob_page_size_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_DataBlob_page_size_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_1 {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_DataBlob_unknown_1_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_DataBlob_unknown_1_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_2 {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_DataBlob_unknown_2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_AcDs_DataBlob_unknown_2_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_AcDs_DataBlobRef ref_ {
    set {
      LibreDWGPINVOKE.Dwg_AcDs_DataBlob_ref__set(swigCPtr, Dwg_AcDs_DataBlobRef.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_AcDs_DataBlob_ref__get(swigCPtr);
      Dwg_AcDs_DataBlobRef ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_AcDs_DataBlobRef(cPtr, false);
      return ret;
    } 
  }

  public Dwg_AcDs_DataBlob() : this(LibreDWGPINVOKE.new_Dwg_AcDs_DataBlob(), true) {
  }

}