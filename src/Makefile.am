libzhttpclientdir=$(pkglibdir)
libzhttpclient_SCRIPTS = libzhttpclient.dll
EXTRA_DIST = $(libzhttpclient_sources) $(libzhttpclient_sources_in)
CLEANFILES = LIBZHttpClient.dll
DISTCLEANFILES = AssemblyInfo.cs Makefile.in

libzhttpclient_sources_in = AssemblyInfo.cs.in
libzhttpclient_generated_sources = $(libzhttpclient_sources_in:.in=)
libzhttpclient_sources = LIBZHttpClient.cs Instrument.cs

libzhttpclient_build_sources = $(addprefix $(srcdir)/, $(libzhttpclient_sources))
libzhttpclient_build_sources += $(libzhttpclient_generated_sources)

libzhttpclient.dll: $(libzhttpclient_build_sources)
	$(MCS) -target:library -out:$@ $(libzhttpclient_build_sources)
