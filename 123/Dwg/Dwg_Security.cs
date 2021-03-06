//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class Dwg_Security : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Dwg_Security(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Dwg_Security obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Dwg_Security() {
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
          LibreDWGPINVOKE.delete_Dwg_Security(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint unknown_1 {
    set {
      LibreDWGPINVOKE.Dwg_Security_unknown_1_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Security_unknown_1_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_2 {
    set {
      LibreDWGPINVOKE.Dwg_Security_unknown_2_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Security_unknown_2_get(swigCPtr);
      return ret;
    } 
  }

  public uint unknown_3 {
    set {
      LibreDWGPINVOKE.Dwg_Security_unknown_3_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Security_unknown_3_get(swigCPtr);
      return ret;
    } 
  }

  public uint crypto_id {
    set {
      LibreDWGPINVOKE.Dwg_Security_crypto_id_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Security_crypto_id_get(swigCPtr);
      return ret;
    } 
  }

  public string crypto_name {
    set {
      LibreDWGPINVOKE.Dwg_Security_crypto_name_set(swigCPtr, value);
    } 
    get {
      string ret = LibreDWGPINVOKE.Dwg_Security_crypto_name_get(swigCPtr);
      return ret;
    } 
  }

  public uint algo_id {
    set {
      LibreDWGPINVOKE.Dwg_Security_algo_id_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Security_algo_id_get(swigCPtr);
      return ret;
    } 
  }

  public uint key_len {
    set {
      LibreDWGPINVOKE.Dwg_Security_key_len_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Security_key_len_get(swigCPtr);
      return ret;
    } 
  }

  public uint encr_size {
    set {
      LibreDWGPINVOKE.Dwg_Security_encr_size_set(swigCPtr, value);
    } 
    get {
      uint ret = LibreDWGPINVOKE.Dwg_Security_encr_size_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char encr_buffer {
    set {
      LibreDWGPINVOKE.Dwg_Security_encr_buffer_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = LibreDWGPINVOKE.Dwg_Security_encr_buffer_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public Dwg_Security() : this(LibreDWGPINVOKE.new_Dwg_Security(), true) {
  }

}
