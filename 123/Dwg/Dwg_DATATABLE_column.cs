//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_DATATABLE_column : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_DATATABLE_column(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_DATATABLE_column obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_DATATABLE_column() {
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
          LibreDWGPINVOKE.delete_Dwg_DATATABLE_column(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Dwg_Object_DATATABLE parent {
    set {
      LibreDWGPINVOKE.Dwg_DATATABLE_column_parent_set(swigCPtr, Dwg_Object_DATATABLE.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_DATATABLE_column_parent_get(swigCPtr);
      Dwg_Object_DATATABLE ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_Object_DATATABLE(cPtr, false);
      return ret;
    } 
  }

  public uint type {
    set {
      LibreDWGPINVOKE.Dwg_DATATABLE_column_type_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_DATATABLE_column_type_get(swigCPtr);
      return ret;
    } 
  }

  public string text {
    set {
      LibreDWGPINVOKE.Dwg_DATATABLE_column_text_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_DATATABLE_column_text_get(swigCPtr);
      return ret;
    } 
  }

  public Dwg_DATATABLE_row rows {
    set {
      LibreDWGPINVOKE.Dwg_DATATABLE_column_rows_set(swigCPtr, Dwg_DATATABLE_row.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_DATATABLE_column_rows_get(swigCPtr);
      Dwg_DATATABLE_row ret = (cPtr == global::System.IntPtr.Zero) ? null : new Dwg_DATATABLE_row(cPtr, false);
      return ret;
    } 
  }

  public Dwg_DATATABLE_column() : this(LibreDWGPINVOKE.new_Dwg_DATATABLE_column(), true) {
  }

}