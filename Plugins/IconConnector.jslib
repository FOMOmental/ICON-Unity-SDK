mergeInto(LibraryManager.library, {


  initial_contract: function () {
  var returnStr = window.config1.contract;
  var bufferSize = lengthBytesUTF8(returnStr) + 1;
  var buffer = _malloc(bufferSize);
  stringToUTF8(returnStr, buffer, bufferSize);
  return buffer;
},
  send_transactions: function(rawtx){
    var tx_raw = Pointer_stringify(rawtx);
    window.send_transactions(tx_raw);
  },

  get_nfts: function () {
    var returnStr = window.nfts;
    var bufferSize = lengthBytesUTF8(returnStr) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  }
});
