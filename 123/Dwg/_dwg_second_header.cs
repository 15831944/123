//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class _dwg_second_header : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal _dwg_second_header(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(_dwg_second_header obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~_dwg_second_header() {
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
          LibreDWGPINVOKE.delete__dwg_second_header(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public _sections section {
    set {
      LibreDWGPINVOKE._dwg_second_header_section_set(swigCPtr, _sections.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE._dwg_second_header_section_get(swigCPtr);
      _sections ret = (cPtr == global::System.IntPtr.Zero) ? null : new _sections(cPtr, false);
      return ret;
    } 
  }

  public _handler handlers {
    set {
      LibreDWGPINVOKE._dwg_second_header_handlers_set(swigCPtr, _handler.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE._dwg_second_header_handlers_get(swigCPtr);
      _handler ret = (cPtr == global::System.IntPtr.Zero) ? null : new _handler(cPtr, false);
      return ret;
    } 
  }

  public uint size {
    set {
      LibreDWGPINVOKE._dwg_second_header_size_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE._dwg_second_header_size_get(swigCPtr);
      return ret;
    } 
  }

  public uint address {
    set {
      LibreDWGPINVOKE._dwg_second_header_address_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE._dwg_second_header_address_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char version {
    set {
      LibreDWGPINVOKE._dwg_second_header_version_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE._dwg_second_header_version_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char null_b {
    set {
      LibreDWGPINVOKE._dwg_second_header_null_b_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE._dwg_second_header_null_b_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public byte unknown_10 {
    set {
      LibreDWGPINVOKE._dwg_second_header_unknown_10_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE._dwg_second_header_unknown_10_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char unknown_rc4 {
    set {
      LibreDWGPINVOKE._dwg_second_header_unknown_rc4_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE._dwg_second_header_unknown_rc4_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public byte num_sections {
    set {
      LibreDWGPINVOKE._dwg_second_header_num_sections_set(swigCPtr, value);
    } 
    get {
      byte ret = LibreDWGPINVOKE._dwg_second_header_num_sections_get(swigCPtr);
      return ret;
    } 
  }

  public ushort num_handlers {
    set {
      LibreDWGPINVOKE._dwg_second_header_num_handlers_set(swigCPtr, value);
    } 
    get {
      ushort ret = LibreDWGPINVOKE._dwg_second_header_num_handlers_get(swigCPtr);
      return ret;
    } 
  }

  public uint junk_r14_1 {
    set {
      LibreDWGPINVOKE._dwg_second_header_junk_r14_1_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE._dwg_second_header_junk_r14_1_get(swigCPtr);
      return ret;
    } 
  }

  public uint junk_r14_2 {
    set {
      LibreDWGPINVOKE._dwg_second_header_junk_r14_2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE._dwg_second_header_junk_r14_2_get(swigCPtr);
      return ret;
    } 
  }

  public _dwg_second_header() : this(LibreDWGPINVOKE.new__dwg_second_header(), true) {
  }

}
